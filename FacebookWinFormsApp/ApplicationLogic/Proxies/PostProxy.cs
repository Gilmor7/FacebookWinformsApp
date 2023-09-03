using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Proxies
{
    public class PostProxy
    {
        private Post m_Post;
        
        public PostProxy(Post i_Post)
        {
            m_Post = i_Post;
        }

        public FacebookObjectCollection<Comment> Comments
        {
            get
            {
                try
                {
                    return m_Post.Comments;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string Message
        {
            get
            {
                try
                {
                    string returnMsg;
                    if(m_Post.Message != null)
                    {
                        returnMsg = m_Post.Message;
                    }
                    else
                    {
                        returnMsg = $"Shared {m_Post.Type.ToString()}";
                    }
                    
                    return returnMsg;
                }
                catch (Exception)
                {
                    return "Error fetching post message";
                }
            }
        }
        
        public string Name
        {
            get
            {
                try
                {
                    return m_Post.Name;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string PictureURL
        {
            get
            {
                try
                {
                    return m_Post.PictureURL;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string Link
        {
            get
            {
                try
                {
                    return m_Post.Link;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string Description
        {
            get
            {
                try
                {
                    return m_Post.Description;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string Caption
        {
            get
            {
                try
                {
                    return m_Post.Caption;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        
        public string Source
        {
            get
            {
                try
                {
                    return m_Post.Source;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}