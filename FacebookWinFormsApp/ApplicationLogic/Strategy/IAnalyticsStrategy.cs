using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public interface IAnalyticsStrategy
    {
        int GetAnalytics(User i_User, User i_SelectedFriend);
    }
}