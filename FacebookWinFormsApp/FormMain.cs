using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_NoUserLoggedInMessage = "No user logged in yet";

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;

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
                labelUserName.Text = $"Hello, {m_LoginResult.LoggedInUser.Name}";
                //buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                //buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            //buttonLogin.Text = "Login";
            //buttonLogin.BackColor = buttonLogout.BackColor;
            labelUserName.Text = k_NoUserLoggedInMessage;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }
    }
}
