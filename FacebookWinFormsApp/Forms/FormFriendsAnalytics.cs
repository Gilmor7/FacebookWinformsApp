using System;
using System.Threading;
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
            new Thread(dataBindUI).Start();
            m_FriendsAnalyticsFeature = new FriendsAnalyticsFeature(UserManager.Instance.LoggedInUser);
        }

        private void dataBindUI()
        {
            new Thread(dataBindFriends).Start();
            new Thread(dataBindAnalysisPanel).Start();
        }

        private void dataBindAnalysisPanel()
        {
            if(panelAnalysis.InvokeRequired)
            {
                panelAnalysis.Invoke(new Action(() => friendsAnalyticsFeatureBindingSource.DataSource = m_FriendsAnalyticsFeature));
            }
            else
            {
                friendsAnalyticsFeatureBindingSource.DataSource = m_FriendsAnalyticsFeature;
            }
        }

        private void dataBindFriends()
        {
            FacebookObjectCollection<User> friends = UserManager.Instance.LoggedInUser.Friends;

            if (listBoxFriendsAnalytics.InvokeRequired)
            {
                listBoxFriendsAnalytics.Invoke(new Action(() => userBindingSource.DataSource = friends));
            }
            else
            {
                userBindingSource.DataSource = friends;
            }
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
                    MessageBox.Show("Couldn't fetch analytics, unknown error occured. setting values to 0.", k_DefaultErrorCaption);
                }
            }
        }
    }
}
