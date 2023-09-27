using System;
using System.ComponentModel;
using BasicFacebookFeatures.ApplicationLogic.Strategy;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Features.FriendsAnalyticsFeature
{
    public class FriendsAnalyticsFeature
    {
        public User LoggedInUser { get; set; }
        public User SelectedFriend { get; set; }
        public IAnalyticsStrategy AnalyticsStrategy { get; set; }
        
        public int GetAnalyticsData()
        {
            return AnalyticsStrategy.GetAnalytics(LoggedInUser, SelectedFriend);
        }
    }
}