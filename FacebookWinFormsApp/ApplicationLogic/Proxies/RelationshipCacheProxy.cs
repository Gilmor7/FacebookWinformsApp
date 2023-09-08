using System.Collections.Generic;
using BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Proxies
{
    public class RelationshipCacheProxy : RelationshipFeature
    {
        private Dictionary<string, FacebookObjectCollection<User>> m_Cache = new Dictionary<string, FacebookObjectCollection<User>>();

        public new FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
        {
            FacebookObjectCollection<User> selectedUserFriends = getFriendsFromCacheOrSelectedFriend();
            FacebookObjectCollection<User> matches = new FacebookObjectCollection<User>();
            
            foreach(User friend in selectedUserFriends)
            {
                if (base.IsPotentialMatch(friend))
                {
                    matches.Add(friend);
                }
            }
            
            return matches;
        }

        private FacebookObjectCollection<User> getFriendsFromCacheOrSelectedFriend()
        {
            FacebookObjectCollection<User> selectedUserFriends;
            bool cacheRetrievalSuccess = m_Cache.TryGetValue(SelectedFriend.Id, out selectedUserFriends);

            if (!cacheRetrievalSuccess)
            {
                selectedUserFriends = SelectedFriend.Friends;
                m_Cache.Add(SelectedFriend.Id, selectedUserFriends);
            }

            return selectedUserFriends;
        }
    }
}