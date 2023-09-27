using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public interface IAnalyticsStrategy
    {
        int GetAnalytics(User i_LoggedInUser, User i_SelectedFriend);
    }
}