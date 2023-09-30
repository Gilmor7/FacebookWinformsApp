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
        private object m_LockObject = new object();
        private ThreadLocal<FriendsAnalyticsFeature> m_ThreadLocalFriendsAnalyticsFeature =
            new ThreadLocal<FriendsAnalyticsFeature>(() => new FriendsAnalyticsFeature());


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
                User selectedFriend = listBoxFriendsAnalytics.SelectedItem as User;
                if (selectedFriend != null)
                {
                    m_FriendsAnalyticsFeature.SelectedFriend = selectedFriend;
                    new Thread(updateDisplayableData).Start();
                }
            }
        }
        
        private void updateDisplayableData()
        {
            new Thread(() => updateAnalyticLabelBasedOnStrategy(labelPostLikesCount, new LikesOnPostAnalytics(null))).Start();
            new Thread(() => updateAnalyticLabelBasedOnStrategy(labelPostCommentsCount, new CommentsOnPostAnalytics(null))).Start();
            new Thread(() => updateAnalyticLabelBasedOnStrategy(labelPhotosLikesCount, new LikesOnPhotosAnalytics(null))).Start();
            new Thread(() => updateAnalyticLabelBasedOnStrategy(labelLikesCount, new LikesOnPhotosAnalytics(new LikesOnPostAnalytics(null)))).Start();
            new Thread(() => updateAnalyticLabelBasedOnStrategy(labelPostEngagementsCount, new LikesOnPostAnalytics(new CommentsOnPostAnalytics(null)))).Start();
        }

        private void updateAnalyticLabelBasedOnStrategy(Label i_LabelToUpdate, IAnalyticsStrategy i_AnalyticsStrategy)
        {
            string textToDisplay = string.Empty;

            try
            {
                FriendsAnalyticsFeature friendsAnalyticsFeature = m_ThreadLocalFriendsAnalyticsFeature.Value;
                friendsAnalyticsFeature.LoggedInUser = m_FriendsAnalyticsFeature.LoggedInUser;
                friendsAnalyticsFeature.SelectedFriend = m_FriendsAnalyticsFeature.SelectedFriend;
                friendsAnalyticsFeature.AnalyticsStrategy = i_AnalyticsStrategy;
                textToDisplay = friendsAnalyticsFeature.GetAnalyticsData().ToString();
            }
            catch (Exception e)
            {
                textToDisplay = "N/A";
            }
            finally
            {
                if(i_LabelToUpdate.InvokeRequired)
                {
                    i_LabelToUpdate.Invoke(new Action(() => i_LabelToUpdate.Text = textToDisplay));
                }
                else
                {
                    i_LabelToUpdate.Text = textToDisplay;
                }
            }
        }
    }
}
