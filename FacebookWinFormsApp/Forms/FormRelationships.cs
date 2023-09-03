﻿using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.Features.RelationshipFeature;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormRelationships : Form
    {
        private const string k_DefaultListBoxDisplayMember = "Name";
        private const string k_DefaultErrorCaption = "Error";

        public FormRelationships()
        {
            InitializeComponent();
            RelationshipFeature.LoggedInUser = UserManager.Instance.LoggedInUser;
        }

        private void ListBoxRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRelationship.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxRelationship.SelectedItem as User;
                if (selectedFriend != null)
                {
                    RelationshipFeature.SelectedFriend = selectedFriend;
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
            RelationshipFeature.InterestedInMales = checkBoxMale.Checked;
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            RelationshipFeature.InterestedInFemales = checkBoxFemale.Checked;
        }

        private void checkBoxSameCity_CheckedChanged(object sender, EventArgs e)
        {
            RelationshipFeature.SameCityLimitPreference = checkBoxSameCity.Checked;
        }

        private void numericUpDownMinAge_ValueChanged(object sender, EventArgs e)
        {
            RelationshipFeature.MinAgePreference = (int)numericUpDownMinAge.Value;
            lowerMaxAgeToMinAgeIfNeeded();
        }

        private void numericUpDownMaxAge_ValueChanged(object sender, EventArgs e)
        {
            RelationshipFeature.MaxAgePreference = (int)numericUpDownMaxAge.Value;
            lowerMaxAgeToMinAgeIfNeeded();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            findAndDisplayMatches();
        }

        private void findAndDisplayMatches()
        {
            try
            {
                FacebookObjectCollection<User> matches = RelationshipFeature.FindMatchesBasedOnPreferences();
                listBoxMatches.Items.Clear();
                listBoxMatches.DisplayMember = k_DefaultListBoxDisplayMember;

                if (matches.Count > 0)
                {
                    foreach (User match in matches)
                    {
                        listBoxMatches.Items.Add(match);
                    }
                }
                else
                {
                    listBoxMatches.Items.Add("There are no matches for you :(");
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You have to select a friend first", k_DefaultErrorCaption);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Couldn't fetch matches, there is an issue with the server", k_DefaultErrorCaption);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch matches, unknown error occured", k_DefaultErrorCaption);
            }
        }
    }
}