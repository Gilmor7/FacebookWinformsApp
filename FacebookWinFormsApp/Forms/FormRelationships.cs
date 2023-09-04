using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature;
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
            m_RelationshipFeature.LoggedUser = UserManager.Instance.LoggedInUser;
            relationshipFeatureBindingSource.DataSource = m_RelationshipFeature;
            listBoxRelationship.DataSource = UserManager.Instance.LoggedInUser.Friends;
            listBoxMatches.DataSource = m_RelationshipFeature.PossibleMatches;
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
    }
}
