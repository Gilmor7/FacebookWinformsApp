using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public class LikesAnalyticsStrategy : IAnalyticsStrategy
    {
        public int GetAnalytics(User i_User, User i_SelectedFriend)
        {
            int numOfLikes = 0;
            
            foreach (Post post in i_User.Posts)
            {
                if(post.LikedBy.Contains(i_SelectedFriend))
                {
                    numOfLikes++;
                }
            }
            
            return numOfLikes;
        }
    }
}