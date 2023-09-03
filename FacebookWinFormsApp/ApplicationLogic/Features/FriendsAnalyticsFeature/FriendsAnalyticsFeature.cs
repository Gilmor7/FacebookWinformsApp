using System;
using System.ComponentModel;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Features.FriendsAnalyticsFeature
{
    public class FriendsAnalyticsFeature : INotifyPropertyChanged
    {
        private User m_LoggedInUser;
        private int m_NumOfLikes;
        private int m_NumOfComments;
        private int m_NumOfOverallEngagements;

        public event PropertyChangedEventHandler PropertyChanged;

        public int NumberOfLikes
        {
            get { return m_NumOfLikes; }
            private set
            {
                m_NumOfLikes = value;
                OnPropertyChanged("NumberOfLikes");
            }
        }

        public int NumberOfComments
        {
            get { return m_NumOfComments; }
            private set
            {
                m_NumOfComments = value;
                OnPropertyChanged("NumberOfComments");
            }
        }

        public int NumberOfOverallEngagements
        {
            get { return m_NumOfOverallEngagements; }
            private set
            {
                m_NumOfOverallEngagements = value;
                OnPropertyChanged("NumberOfOverallEngagements");
            }
        }

        public FriendsAnalyticsFeature(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void UpdateInternalEngagementsBasedOnSelectedFriend(User i_SelectedFriend)
        {
            if(i_SelectedFriend == null)
            {
                NumberOfLikes = 0;
                NumberOfComments = 0;
                NumberOfOverallEngagements = 0;
            }
            else
            {
                int numOfLikes = 0;
                int numOfComments = 0;
                try
                {
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        if (post.LikedBy.Contains(i_SelectedFriend))
                        {
                            numOfLikes++;
                        }

                        foreach (Comment comment in post.Comments)
                        {
                            if (comment.From == i_SelectedFriend)
                            {
                                numOfComments++;
                            }
                        }

                        NumberOfLikes = numOfLikes;
                        NumberOfComments = numOfComments;
                        NumberOfOverallEngagements = NumberOfLikes + NumberOfComments;
                    }
                }
                catch (Exception e)
                {
                    NumberOfLikes = 0;
                    NumberOfComments = 0;
                    NumberOfOverallEngagements = 0;
                    throw new Exception("Error occured while trying to calculate engagements", e);
                }
            }
        }

        protected virtual void OnPropertyChanged(string i_PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
            }
        }
    }
}