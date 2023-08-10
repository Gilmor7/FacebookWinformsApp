using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_NoUserLoggedInMessage = "No user logged in yet";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        // protected override void OnShown(EventArgs e)
        // {
        //     base.OnShown(e);
        //     fetchDataAndPopulateListBoxes();
        // }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                "1444657766108962",
                "email",
                "public_profile",
                "user_gender",
                "user_age_range",
                "user_birthday",
                "user_hometown",
                "user_photos",
                "user_posts",
                "user_friends"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                labelUserName.Text = $"Hello, {m_LoginResult.LoggedInUser.Name}";
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogin.Cursor = Cursors.No;
                buttonLogout.Enabled = true;
                buttonLogout.Cursor = Cursors.Hand;
                fetchDataAndPopulateListBoxes();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            labelUserName.Text = k_NoUserLoggedInMessage;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogout.Enabled = false;
            buttonLogout.Cursor = Cursors.No;
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
            
            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page.Name);
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
            
            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxAlbums.Items.Add(album.Name);
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
            
            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend.Name);
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    listBoxFriends.Items.Add("There are no facebook friends available");
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Couldn't fetch facebook friends");
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
            
            try
            {
                foreach (Event facebookEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(facebookEvent.Name);
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
    }
}
