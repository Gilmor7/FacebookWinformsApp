using System;
using System.ComponentModel;
using System.Threading;
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
        private RelationshipFeature m_RelationshipFeature = new RelationshipFeature();

        public FormRelationships()
        {
            InitializeComponent();
            new Thread(dataBindUI).Start();
            m_RelationshipFeature.LoggedInUser = UserManager.Instance.LoggedInUser;
        }

        private void dataBindUI()
        {
            new Thread(dataBindFriends).Start();
            new Thread(dataBindPossibleMatches).Start();
        }

        private void dataBindPossibleMatches()
        {
            if (listBoxMatches.InvokeRequired)
            {
                listBoxMatches.Invoke(new Action(() => possibleMatchesBindingSource.DataSource = m_RelationshipFeature.PossibleMatches));
            }
            else
            {
                possibleMatchesBindingSource.DataSource = m_RelationshipFeature.PossibleMatches;
            }
        }

        private void dataBindFriends()
        {
            FacebookObjectCollection<User> friends = UserManager.Instance.LoggedInUser.Friends;

            if (listBoxRelationship.InvokeRequired)
            {
                listBoxRelationship.Invoke(new Action(() => userBindingSource.DataSource = friends));
            }
            else
            {
                userBindingSource.DataSource = friends;
            }
        }

        private void ListBoxRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRelationship.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxRelationship.SelectedItem as User;
                if (selectedFriend != null)
                {
                    m_RelationshipFeature.SelectedFriend = selectedFriend;
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

        private void M_RelationshipFeature_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            dataBindPossibleMatches();
        }

    }
}
