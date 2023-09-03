using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using BasicFacebookFeatures.ApplicationLogic.Proxies;
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
        private FriendsAnalyticsFeature m_FriendsAnalyticsFeature;

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
                m_FriendsAnalyticsFeature = new FriendsAnalyticsFeature(r_User.LoggedInUser);
                new Thread(fetchUserInfo).Start();
                changeLoginAndLogoutButtonsState(i_IsLogin: true);
                new Thread(fetchDataAndPopulateListBoxes).Start();
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
            User user = r_User.LoggedInUser;

            if(labelUserName.InvokeRequired)
            {
                labelUserName.Invoke(new Action(() => userBindingSource.DataSource = user));
            }
            else
            {
                userBindingSource.DataSource = user;
            }
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
            new Thread(fetchPostsAndPopulateListBox).Start();
            new Thread(fetchAndPopulateUserFriendsListBoxes).Start();
            new Thread(fetchPagesAndPopulateListBox).Start();
            new Thread(fetchAlbumsAndPopulateListBox).Start();
            new Thread(fetchEventsAndPopulateListBox).Start();
        }

        private void fetchPagesAndPopulateListBox()
        {
            FacebookObjectCollection<Page> likedPages = r_User.LoggedInUser.LikedPages;

            if(listBoxPages.InvokeRequired)
            {
                listBoxPages.Invoke(new Action(() => pageBindingSource.DataSource = likedPages));
            }
            else
            {
                pageBindingSource.DataSource = likedPages;
            }
        }
        
        private void fetchAlbumsAndPopulateListBox()
        {
            FacebookObjectCollection<Album> albums = r_User.LoggedInUser.Albums;

            if(listBoxAlbums.InvokeRequired)
            {
                listBoxAlbums.Invoke(new Action(() => albumsBindingSource.DataSource = albums));
            }
            else
            {
                albumsBindingSource.DataSource = albums;
            }
        }

        private void fetchAndPopulateUserFriendsListBoxes()
        {
            FacebookObjectCollection<User> friends = r_User.LoggedInUser.Friends;

            if(listBoxFriends.InvokeRequired)
            {
                listBoxFriends.Invoke(new Action(() => userFriendsBindingSource.DataSource = friends));
            }
            else
            {
                userFriendsBindingSource.DataSource = friends;
            }
        }

        private void fetchPostsAndPopulateListBox()
        {
            FacebookObjectCollection<PostProxy> posts = new FacebookObjectCollection<PostProxy>();
            
            foreach(Post post in r_User.LoggedInUser.Posts)
            {
                posts.Add(new PostProxy(post));
            }

            if(listBoxPosts.InvokeRequired)
            {
                listBoxPosts.Invoke(new Action(() => postedItemBindingSource.DataSource = posts));
            }
            else
            {
                postedItemBindingSource.DataSource = posts;
            }
        }

        private void fetchEventsAndPopulateListBox()
        {
            FacebookObjectCollection<Event> events = r_User.LoggedInUser.Events;

            if(listBoxEvents.InvokeRequired)
            {
                listBoxEvents.Invoke(new Action(() => eventsBindingSource.DataSource = events));
            }
            else
            {
                eventsBindingSource.DataSource = events;
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

        private void buttonPost_Click(object sender, EventArgs e)
        {
           postStatus();
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

        private void listBoxFriendsAnalytics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when we will seperate this to another form, we might need to change this if statement
            if(listBoxFriendsAnalytics.SelectedItems.Count == 1 && tabControlFormMain.SelectedTab == tabPageAnalytics)
            {
                try
                {
                    User selectedFriend = listBoxFriendsAnalytics.SelectedItem as User;
                    if (selectedFriend != null)
                    {
                        m_FriendsAnalyticsFeature.UpdateInternalEngagmentsBasedOnSelectedFriend(selectedFriend);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't fetch analytics, unknown error occured", k_DefaultErrorCaption);
                }
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(updateCommentsBasedOnSelectedPost).Start();
        }

        private void updateCommentsBasedOnSelectedPost()
        {
            if(listBoxPosts.SelectedItems.Count == 1 && listBoxPosts.SelectedItem is PostProxy selectedPost)
            {
                FacebookObjectCollection<Comment> comments = selectedPost.Comments;

                if(comments.Count == 0)
                {
                    commentsBindingSource.DataSource = new List<string>() { "No comments to show" };
                }
                else
                {
                    if(listBoxPostComments.InvokeRequired)
                    {
                        listBoxPostComments.Invoke(new Action(() => commentsBindingSource.DataSource = comments));
                    }
                    else
                    {
                        commentsBindingSource.DataSource = comments;
                    }   
                }
            }
        }
    }
}
