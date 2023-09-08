using System;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.ApplicationLogic
{
    public sealed class UserManager
    {
        private static readonly object sr_CreationLockContext = new object();
        private const string k_AppId = "1444657766108962";
        private readonly string[] r_Permissions = new string[]
        {
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
            "user_videos"
        };

        private LoginResult m_LoginResult = null;
        private static UserManager s_This = null;

        private UserManager()
        {
            
        }
        

        public static UserManager Instance
        {
            get
            {
                if (s_This == null)
                {
                    lock (sr_CreationLockContext)
                    {
                        if (s_This == null)
                        {
                            s_This = new UserManager();
                        }
                    }
                }

                return s_This;
            }
        }
        public User LoggedInUser
        {
            get
            {
                return m_LoginResult != null ? m_LoginResult.LoggedInUser : null;
            }
        }
        
        public void Login()
        {
            try
            {
                m_LoginResult = FacebookService.Login(k_AppId, r_Permissions);
                if (m_LoginResult != null && string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    throw new Exception(m_LoginResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
        }
    }
}