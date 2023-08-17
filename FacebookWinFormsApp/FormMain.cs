using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
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
        private readonly UserManager r_User = new UserManager();
        
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void loginAndPopulateUserData()
        {
            try
            {
                r_User.Login();
                RelationshipFeature.LoggedInUser = r_User.LoggedInUser;
                fetchUserInfo();
                changeLoginAndLogoutButtonsState(i_IsLogin: true);
                fetchDataAndPopulateListBoxes();
                showTabPages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
        }
        
        private void changeLoginAndLogoutButtonsState(bool i_IsLogin)
        {
            buttonLogin.Enabled = !i_IsLogin;
            buttonLogout.Enabled = i_IsLogin;

            if (i_IsLogin)
            {
                buttonLogin.Cursor =  Cursors.No;
                buttonLogout.Cursor = Cursors.Hand;
            }
            else
            {
                buttonLogin.Cursor =  Cursors.Hand;
                buttonLogout.Cursor = Cursors.No;
            }
        }
        
        private void showTabPages()
        {
            tabControlFormMain.TabPages.Add(tabPageAnalytics);
            tabControlFormMain.TabPages.Add(tabPageFindMatch);
        }
        
        private void hideTabPages()
        {
            tabControlFormMain.TabPages.Remove(tabPageAnalytics);
            tabControlFormMain.TabPages.Remove(tabPageFindMatch);
        }

        private void fetchUserInfo()
        {
            labelUserName.Text = $"Hello, {r_User.LoggedInUser.Name}";
            pictureBoxProfile.LoadAsync(r_User.LoggedInUser.PictureNormalURL);

            if (r_User.LoggedInUser.Posts.Count > 0 && r_User.LoggedInUser.Posts[0].Message != null)
            {
                textBoxStatus.Text = r_User.LoggedInUser.Posts[0].Message;
            }
            else
            {
                textBoxStatus.Text = "This is my first status!";
            }

            textBoxStatus.SelectionLength = 0;
        }

        private void handleLogout()
        {
            r_User.Logout();
            labelUserName.Text = k_NoUserLoggedInMessage;
            changeLoginAndLogoutButtonsState(i_IsLogin: false);
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            loginAndPopulateUserData();
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
                foreach (Page page in r_User.LoggedInUser.LikedPages)
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
                foreach (Album album in r_User.LoggedInUser.Albums)
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
            listBoxFriendsAnalytics.Items.Clear();
            listBoxRelationship.Items.Clear();
            listBoxFriendsAnalytics.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxFriends.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxRelationship.DisplayMember = k_DefaultListBoxDisplayMember;
            
            try
            {
                foreach (User friend in r_User.LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                    listBoxFriendsAnalytics.Items.Add(friend);
                    listBoxRelationship.Items.Add(friend);
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    listBoxFriends.Items.Add("There are no facebook friends available");
                    listBoxFriendsAnalytics.Items.Add("There are no facebook friends available");
                    listBoxRelationship.Items.Add("There are no facebook friends available");
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Couldn't fetch facebook friends");
                listBoxFriendsAnalytics.Items.Add("Couldn't fetch facebook friends");
                listBoxRelationship.Items.Add("Couldn't fetch facebook friends");
            }
        }

        private void fetchPostsAndPopulateListBox()
        {
            listBoxPosts.Items.Clear();

            try
            {
                foreach (Post post in r_User.LoggedInUser.Posts)
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
                        listBoxPosts.Items.Add($"[{post.Type}]");
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
                foreach (Event facebookEvent in r_User.LoggedInUser.Events)
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
            Post selectedPost = r_User.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
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
                if (r_User.LoggedInUser != null)
                {
                    r_User.LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("The status was Posted!", k_DefaultSuccessCaption);
                    fetchPostsAndPopulateListBox();
                }
                else
                {
                    throw new Exception("You have to login first!");
                }

            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show(k_DefaultServerErrorMessage, k_DefaultErrorCaption);
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
            showSelectedFriendAnalytics();
        }

        private void showSelectedFriendAnalytics()
        {
            if (listBoxFriendsAnalytics.SelectedItems.Count == 1 && listBoxFriendsAnalytics.SelectedItem is User selectedFriend)
            {
                string numOfLikesStr = k_DefaultServerErrorMessage;
                string numOfCommentsStr = k_DefaultServerErrorMessage;
                string numOfAllStr = k_DefaultServerErrorMessage;
                
                try
                {
                    PictureBoxFriendsAnalytics.LoadAsync(selectedFriend.PictureNormalURL);
                }
                catch (Exception )
                {
                    MessageBox.Show("Couldn't fetch friend's profile picture", k_DefaultErrorCaption);
                }

                try
                {
                    int numOfLikes = FriendsAnalyticsFeature.GetNumberOfEngagementsFromFriend(
                        r_User.LoggedInUser,
                        selectedFriend,
                        eEngagmentType.Likes);
                    int numOfComments = FriendsAnalyticsFeature.GetNumberOfEngagementsFromFriend(
                        r_User.LoggedInUser,
                        selectedFriend,
                        eEngagmentType.Comments);
                    int numOfAll = numOfLikes + numOfComments;

                    numOfLikesStr = numOfLikes.ToString();
                    numOfCommentsStr = numOfComments.ToString();
                    numOfAllStr = $"The user {selectedFriend.Name} has {numOfAll} engagements with you";
                }
                catch(FacebookOAuthException)
                {
                    MessageBox.Show("Couldn't fetch friend's analytics, there is an issue with the server", k_DefaultErrorCaption);
                }
                catch(Exception)
                {
                    MessageBox.Show("Couldn't fetch friend's analytics, unknown error occured", k_DefaultErrorCaption);
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
            if(listBoxRelationship.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxRelationship.SelectedItem as User;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            hideTabPages();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("New tabs with extra features will be available after login", "Welcome!");
        }
    }
}
