using BasicFacebookFeatures.ApplicationLogic.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Decoretor
{
    public abstract class AnalyticsStrategyDecoretor : IAnalyticsStrategy
    {
        public IAnalyticsStrategy AnalyticsStrategy { get; set; }

        public AnalyticsStrategyDecoretor(IAnalyticsStrategy i_AnalyticsStrategy)
        {
            AnalyticsStrategy = i_AnalyticsStrategy;
        }

        public abstract int GetAnalytics(User i_LoggedInUser, User i_SelectedFriend);

    }
}
