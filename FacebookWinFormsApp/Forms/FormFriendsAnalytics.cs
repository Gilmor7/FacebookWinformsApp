using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.Features.FriendsAnalyticsFeature;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriendsAnalytics : Form
    {
        private const string k_DefaultErrorCaption = "Error";
        private FriendsAnalyticsFeature m_FriendsAnalyticsFeature;

        public FormFriendsAnalytics()
        {
            InitializeComponent();
            m_FriendsAnalyticsFeature = new FriendsAnalyticsFeature(UserManager.Instance.LoggedInUser);
        }

        private void listBoxFriendsAnalytics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriendsAnalytics.SelectedItems.Count == 1)
            {
                try
                {
                    User selectedFriend = listBoxFriendsAnalytics.SelectedItem as User;
                    if (selectedFriend != null)
                    {
                        m_FriendsAnalyticsFeature.UpdateInternalEngagementsBasedOnSelectedFriend(selectedFriend);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't fetch analytics, unknown error occured", k_DefaultErrorCaption);
                }
            }
        }
    }
}
