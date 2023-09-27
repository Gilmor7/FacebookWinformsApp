using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.ApplicationLogic.Features.FriendsAnalyticsFeature;
using BasicFacebookFeatures.ApplicationLogic.Strategy;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriendsAnalytics : Form
    {
        private FriendsAnalyticsFeature m_FriendsAnalyticsFeature;

        public FormFriendsAnalytics()
        {
            InitializeComponent();
            new Thread(dataBindUI).Start();
            m_FriendsAnalyticsFeature = new FriendsAnalyticsFeature();
            m_FriendsAnalyticsFeature.LoggedInUser = UserManager.Instance.LoggedInUser;
        }

        private void dataBindUI()
        {
            new Thread(dataBindFriends).Start();
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
                        m_FriendsAnalyticsFeature.SelectedFriend = selectedFriend;
                        updateDisplayableData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't fetch analytics, unknown error occured.", ApplicationMessages.k_DefaultErrorCaption);
                }
            }
        }
        
        private void updateDisplayableData()
        {
            updateLikesCount();
            updateCommentsCount();
        }

        private void updateLikesCount()
        {
            m_FriendsAnalyticsFeature.AnalyticsStrategy = new LikesAnalyticsStrategy();
            int likesCount = m_FriendsAnalyticsFeature.GetAnalyticsData();
            labelLikesCount.Text = likesCount.ToString();
        }
        
        private void updateCommentsCount()
        {
            m_FriendsAnalyticsFeature.AnalyticsStrategy = new CommentsAnalyticsStrategy();
            int commentsCount = m_FriendsAnalyticsFeature.GetAnalyticsData();
            labelCommentsCount.Text = commentsCount.ToString();
        }
    }
}
