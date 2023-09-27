using BasicFacebookFeatures.ApplicationLogic.Decoretor;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public class CommentsOnPostAnalytics : AnalyticsStrategyDecoretor
    {
        public CommentsOnPostAnalytics(IAnalyticsStrategy i_AnalyticsStrategy) : base(i_AnalyticsStrategy)
        {
        }

        public override int GetAnalytics(User i_User, User i_SelectedFriend)
        {
            int analyticsCount = 0;

            foreach (Post post in i_User.Posts)
            {
                foreach (Comment comment in post.Comments)
                {
                    if (comment.From.Id == i_SelectedFriend.Id)
                    {
                        analyticsCount++;
                    }
                }
            }

            analyticsCount += AnalyticsStrategy?.GetAnalytics(i_User, i_SelectedFriend) ?? 0;

            return analyticsCount;
        }
    }
}
