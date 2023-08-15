using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Features.FriendsAnalyticsFeature;
using BasicFacebookFeatures.Features.RelationshipFeature;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_NoUserLoggedInMessage = "No user logged in yet";
        private const string k_DefaultListBoxDisplayMember = "Name";
        private const string k_DefaultErrorCaption = "Error";
        private const string k_DefaultSuccessCaption = "Success";
        private const string k_DefaultServerErrorMessage = "an Error occured while trying to reach the Facebook server, please try again later";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void loginAndPopulateUserData()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                    "1444657766108962",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonLogin.Cursor = Cursors.No;
                buttonLogout.Enabled = true;
                buttonLogout.Cursor = Cursors.Hand;
                fetchDataAndPopulateListBoxes();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            labelUserName.Text = $"Hello, {m_LoggedInUser.Name}";
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);

            if (m_LoggedInUser.Posts.Count > 0 && m_LoggedInUser.Posts[0].Message != null)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
            else
            {
                textBoxStatus.Text = "This is my first status!";
            }

            textBoxStatus.SelectionLength = 0;
        }

        private void handleLogout()
        {
            FacebookService.LogoutWithUI();
            labelUserName.Text = k_NoUserLoggedInMessage;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogout.Enabled = false;
            buttonLogout.Cursor = Cursors.No;
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                loginAndPopulateUserData();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }

        private void fetchDataAndPopulateListBoxes()
        {
            fetchPostsAndPopulateListBox();
            fetchFriendsAndPopulateListBox();
            fetchPagesAndPopulateListBox();
            fetchAlbumsAndPopulateListBox();
            fetchEventsAndPopulateListBox();
        }

        private void fetchPagesAndPopulateListBox()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = k_DefaultListBoxDisplayMember;
            
            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }

                if (listBoxPages.Items.Count == 0)
                {
                    listBoxPages.Items.Add("There are no liked pages");
                }
            }
            catch (Exception)
            {
                listBoxPages.Items.Add("Couldn't fetch liked pages");
            }
        }
        
        private void fetchAlbumsAndPopulateListBox()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = k_DefaultListBoxDisplayMember;
            
            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxAlbums.Items.Add(album);
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    listBoxAlbums.Items.Add("There are no albums available");
                }
            }
            catch (Exception)
            {
                listBoxAlbums.Items.Add("Couldn't fetch albums");
            }
        }

        private void fetchFriendsAndPopulateListBox()
        {
            listBoxFriends.Items.Clear();
            ListBoxFriendsAnalytics.Items.Clear();
            ListBoxRelationship.Items.Clear();
            ListBoxFriendsAnalytics.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxFriends.DisplayMember = k_DefaultListBoxDisplayMember;
            ListBoxRelationship.DisplayMember = k_DefaultListBoxDisplayMember;
            
            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                    ListBoxFriendsAnalytics.Items.Add(friend);
                    ListBoxRelationship.Items.Add(friend);
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    listBoxFriends.Items.Add("There are no facebook friends available");
                    ListBoxFriendsAnalytics.Items.Add("There are no facebook friends available");
                    ListBoxRelationship.Items.Add("There are no facebook friends available");
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Couldn't fetch facebook friends");
                ListBoxFriendsAnalytics.Items.Add("Couldn't fetch facebook friends");
                ListBoxRelationship.Items.Add("Couldn't fetch facebook friends");
            }
        }

        private void fetchPostsAndPopulateListBox()
        {
            listBoxPosts.Items.Clear();

            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    listBoxPosts.Items.Add("There are no posts available");
                }
            }
            catch (Exception)
            {
                listBoxPosts.Items.Add("Couldn't fetch posts");
            }
        }

        private void fetchEventsAndPopulateListBox()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = k_DefaultListBoxDisplayMember;
            
            try
            {
                foreach (Event facebookEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(facebookEvent);
                }

                if (listBoxEvents.Items.Count == 0)
                {
                    listBoxEvents.Items.Add("There are no events available");
                }
            }
            catch (Exception)
            {
                listBoxEvents.Items.Add("Couldn't fetch events");
            }
        }

        private void displaySelectedFriendPhoto()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if(selectedFriend != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureSmallURL);
                }
            }
        }
        
        private void displaySelectedPagePhoto()
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                if(selectedPage != null)
                {
                    pictureBoxPage.LoadAsync(selectedPage.PictureSmallURL);
                }
            }
        }
        
        private void displaySelectedAlbumPhoto()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if(selectedAlbum != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureSmallURL);
                }
            }
        }

        private void displayPostComments()
        {
            Post selectedPost = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            FacebookObjectCollection<Comment> postComments = selectedPost.Comments;

            listBoxPostComments.Items.Clear();
            if (postComments.Count > 0)
            {
                listBoxPostComments.DataSource = postComments;
                listBoxPostComments.DisplayMember = "Message";
            }
            else
            {
                listBoxPostComments.Items.Add("No comments available :(");
            }
        }

        private void postStatus()
        {
            try
            {
                if (m_LoggedInUser != null)
                {
                    m_LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("The status was Posted!", k_DefaultSuccessCaption);
                    fetchPostsAndPopulateListBox();
                }
                else
                {
                    throw new Exception("You have to login first!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_DefaultErrorCaption);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriendPhoto();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPagePhoto();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbumPhoto();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
           postStatus();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPostComments();
        }

        private void ButtonSelectFriend_Click(object sender, EventArgs e)
        {
            showSelectedFriendsAnalytics();
        }

        private void showSelectedFriendsAnalytics()
        {
            if (ListBoxFriendsAnalytics.SelectedItems.Count == 1)
            {
                User selectedFriend = ListBoxFriendsAnalytics.SelectedItem as User;
                string numOfLikesStr = k_DefaultServerErrorMessage;
                string numOfCommentsStr = k_DefaultServerErrorMessage;
                string numOfAllStr = k_DefaultServerErrorMessage;
                
                try
                {
                    if(selectedFriend != null)
                    {
                        PictureBoxFriendsAnalytics.LoadAsync(selectedFriend.PictureNormalURL);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't fetch friend's profile picture");
                }

                try
                {
                    int numOfLikes = FriendsAnalyticsFeature.GetNumberOfEngagementsFromFriend(
                        m_LoggedInUser,
                        selectedFriend,
                        eEngagmentType.Likes);
                    int numOfComments = FriendsAnalyticsFeature.GetNumberOfEngagementsFromFriend(
                        m_LoggedInUser,
                        selectedFriend,
                        eEngagmentType.Comments);
                    int numOfAll = numOfLikes + numOfComments;

                    numOfLikesStr = numOfLikes.ToString();
                    numOfCommentsStr = numOfComments.ToString();
                    numOfAllStr = $"The user {selectedFriend.Name} has {numOfAll} engagments with you";
                }
                catch(FacebookOAuthException)
                {
                    MessageBox.Show("Couldn't fetch friend's analytics, there is an issue with the server");
                }
                catch(Exception)
                {
                    MessageBox.Show("Couldn't fetch friend's analytics, unknown error occured");
                }
                finally
                {
                    LabelLikesNum.Text = numOfLikesStr;
                    LabelCommentsNum.Text = numOfCommentsStr;
                    LabelOverallEngagments.Text = numOfAllStr;
                }
            }
        }
        
        private void ListBoxRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBoxRelationship.SelectedItems.Count == 1)
            {
                User selectedFriend = ListBoxRelationship.SelectedItem as User;
                if(selectedFriend != null)
                {
                    RelationshipFeature.SelectedFriend = selectedFriend;
                }
            }
        }

        private void lowerMaxAgeToMinAgeIfNeeded()
        {
            int minAge = (int)numericUpDownMinAge.Value;
            int maxAge = (int)numericUpDownMaxAge.Value;

            if(maxAge < minAge)
            {
                numericUpDownMaxAge.Value = minAge;
            }
        }

        private void CheckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            RelationshipFeature.InterestedInMales = CheckBoxMale.Checked;
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            RelationshipFeature.InterestedInFemales = CheckBoxFemale.Checked;
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
                MessageBox.Show("You have to select a friend first");
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Couldn't fetch matches, there is an issue with the server");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't fetch matches, unknown error occured");
            }
        }
    }
}
