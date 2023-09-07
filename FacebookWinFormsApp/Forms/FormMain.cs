using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.ApplicationLogic;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.ApplicationLogic.Proxies;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormMain : FormProxy
    {
        private const string k_NoUserLoggedInMessage = "No user logged in yet";
        private const string k_DefaultErrorCaption = "Error";
        private const string k_DefaultSuccessCaption = "Success";
        private const string k_DefaultServerErrorMessage = "an Error occured while trying to reach the Facebook server, please try again later";
        
        private User m_LoggeInUser = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void loginAndPopulateUserData()
        {
            try
            {
                UserManager.Instance.Login();
                m_LoggeInUser = UserManager.Instance.LoggedInUser;
                new Thread(fetchUserInfo).Start();
                changeButtonsStateAccordingToConnectionStatus(i_IsLogin: true);
                new Thread(fetchDataAndPopulateListBoxes).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
        }
        
        private void changeButtonsStateAccordingToConnectionStatus(bool i_IsLogin)
        {
            buttonLogin.Enabled = !i_IsLogin;
            buttonLogout.Enabled = i_IsLogin;

            buttonAnalytics.Enabled = i_IsLogin;
            buttonRelationships.Enabled = i_IsLogin;

            if (i_IsLogin)
            {
                buttonLogin.Cursor =  Cursors.No;
                buttonLogout.Cursor = Cursors.Hand;
                buttonAnalytics.Cursor = Cursors.Hand;
                buttonRelationships.Cursor = Cursors.Hand;
            }
            else
            {
                buttonLogin.Cursor =  Cursors.Hand;
                buttonLogout.Cursor = Cursors.No;
                buttonAnalytics.Cursor = Cursors.No;
                buttonRelationships.Cursor = Cursors.No;
            }
        }

        private void fetchUserInfo()
        {
            if(labelUserName.InvokeRequired)
            {
                labelUserName.Invoke(new Action(() => userBindingSource.DataSource = m_LoggeInUser));
            }
            else
            {
                userBindingSource.DataSource = m_LoggeInUser;
            }
        }

        private void handleLogout()
        {
            UserManager.Instance.Logout();
            labelUserName.Text = k_NoUserLoggedInMessage;
            changeButtonsStateAccordingToConnectionStatus(i_IsLogin: false);
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
        
        private void fetchAndPopulateUserFriendsListBoxes()
        {
            if(listBoxFriends.InvokeRequired)
            {
                listBoxFriends.Invoke(new Action(() => userFriendsBindingSource.DataSource = m_LoggeInUser.Friends));
            }
            else
            {
                userFriendsBindingSource.DataSource = m_LoggeInUser.Friends;
            }
        }

        private void fetchPagesAndPopulateListBox()
        {
            FacebookObjectCollection<Page> likedPages = m_LoggeInUser.LikedPages;

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
            FacebookObjectCollection<Album> albums = m_LoggeInUser.Albums;

            if(listBoxAlbums.InvokeRequired)
            {
                listBoxAlbums.Invoke(new Action(() => albumsBindingSource.DataSource = albums));
            }
            else
            {
                albumsBindingSource.DataSource = albums;
            }
        }

        private void fetchPostsAndPopulateListBox()
        {
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();
            
            foreach(Post post in m_LoggeInUser.Posts)
            {
                posts.Add(post);
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
            FacebookObjectCollection<Event> events = m_LoggeInUser.Events;

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
                if (m_LoggeInUser != null)
                {
                    m_LoggeInUser.PostStatus(textBoxStatus.Text);
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

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCommentsBasedOnSelectedPost();
        }

        private void updateCommentsBasedOnSelectedPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1 && listBoxPosts.SelectedItem is Post selectedPost)
            {
                FacebookObjectCollection<Comment> comments = selectedPost.Comments;

                if (comments.Count == 0)
                {
                    commentsBindingSource.DataSource = new List<string>() { "No comments to show" };
                }
                else
                {
                    if (listBoxPostComments.InvokeRequired)
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

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            Form formAnalytics = FormsFactory.CreateForm(FormsFactory.eFormType.FormFriendsAnalytics);
            formAnalytics.ShowDialog();
        }

        private void buttonRelationships_Click(object sender, EventArgs e)
        {
            Form formRelationships = FormsFactory.CreateForm(FormsFactory.eFormType.FormRelationships);
            formRelationships.ShowDialog();
        }
    }
}
