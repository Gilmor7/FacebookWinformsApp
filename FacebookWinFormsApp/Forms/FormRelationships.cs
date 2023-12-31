﻿using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature;
using BasicFacebookFeatures.ApplicationLogic.Proxies;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormRelationships : Form
    {
        private readonly IRelationShipFeature r_RelationshipFeature = new RelationshipCacheProxy();

        public FormRelationships()
        {
            InitializeComponent();
            populateFriendsListBox();
            r_RelationshipFeature.LoggedInUser = UserManager.Instance.LoggedInUser;
        }

        private void populateFriendsListBox()
        {
            FacebookObjectCollection<User> friends = UserManager.Instance.LoggedInUser.Friends;
            listBoxMatches.Items.Clear();
            listBoxRelationship.DisplayMember = ApplicationMessages.k_DefaultListBoxDisplayMember;

            foreach (User friend in friends)
            {
                listBoxRelationship.Items.Add(friend);
            }

        }

        private void ListBoxRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRelationship.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxRelationship.SelectedItem as User;
                if (selectedFriend != null)
                {
                    r_RelationshipFeature.SelectedFriend = selectedFriend;
                }
            }
        }

        private void lowerMaxAgeToMinAgeIfNeeded()
        {
            int minAge = (int)numericUpDownMinAge.Value;
            int maxAge = (int)numericUpDownMaxAge.Value;

            if (maxAge < minAge)
            {
                numericUpDownMaxAge.Value = minAge;
            }
        }

        private void CheckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            r_RelationshipFeature.InterestedInMales = checkBoxMale.Checked;
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            r_RelationshipFeature.InterestedInFemales = checkBoxFemale.Checked;
        }

        private void checkBoxSameCity_CheckedChanged(object sender, EventArgs e)
        {
            r_RelationshipFeature.SameCityLimitPreference = checkBoxSameCity.Checked;
        }

        private void numericUpDownMinAge_ValueChanged(object sender, EventArgs e)
        {
            lowerMaxAgeToMinAgeIfNeeded();
            r_RelationshipFeature.MinAgePreference = (int)numericUpDownMinAge.Value;
        }

        private void numericUpDownMaxAge_ValueChanged(object sender, EventArgs e)
        {
            lowerMaxAgeToMinAgeIfNeeded();
            r_RelationshipFeature.MaxAgePreference = (int)numericUpDownMaxAge.Value;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            findAndDisplayMatches();
        }

        private void findAndDisplayMatches()
        {
            try
            {
                listBoxMatches.Items.Clear();
                listBoxMatches.DisplayMember = ApplicationMessages.k_DefaultListBoxDisplayMember;
                
                foreach (User match in r_RelationshipFeature)
                {
                    listBoxMatches.Items.Add(match);
                }
                
                if (listBoxMatches.Items.Count == 0)
                {
                    listBoxMatches.Items.Add(ApplicationMessages.k_NoMatchesFoundMessage);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You have to select a friend first", ApplicationMessages.k_DefaultErrorCaption);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Couldn't fetch matches, there is an issue with the server", ApplicationMessages.k_DefaultErrorCaption);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch matches, unknown error occured", ApplicationMessages.k_DefaultErrorCaption);
            }
        }
    }
}
