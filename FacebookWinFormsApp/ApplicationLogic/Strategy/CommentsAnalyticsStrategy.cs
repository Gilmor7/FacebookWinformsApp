using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public class CommentsAnalyticsStrategy : IAnalyticsStrategy
    {
        public int GetAnalytics(User i_User, User i_SelectedFriend)
        {
            int numOfComments = 0;

            foreach (Post post in i_User.Posts)
            {
                foreach (Comment comment in post.Comments)
                {
                    if (comment.From.Id == i_SelectedFriend.Id)
                    {
                        numOfComments++;
                    }
                }
            }

            return numOfComments;
        }
    }
}