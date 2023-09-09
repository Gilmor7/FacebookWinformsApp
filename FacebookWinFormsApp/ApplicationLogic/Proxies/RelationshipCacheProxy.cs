using System;
using System.Collections.Generic;
using BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Proxies
{
    public class RelationshipCacheProxy : IRelationShipFeature
    {
        private Dictionary<string, FacebookObjectCollection<User>> m_Cache = new Dictionary<string, FacebookObjectCollection<User>>();
        private RelationshipFeature m_RelationshipFeature = new RelationshipFeature();

        public User LoggedInUser
        {
            get
            {
                return m_RelationshipFeature.LoggedInUser;
            }
            set
            {
                m_RelationshipFeature.LoggedInUser = value;
            }
        }

        public User SelectedFriend
        {
            get
            {
                return m_RelationshipFeature.SelectedFriend;
            }
            set
            {
                m_RelationshipFeature.SelectedFriend = value;
            }
        }

        public bool InterestedInMales
        {
            get
            {
                return m_RelationshipFeature.InterestedInMales;
            }
            set
            {
                m_RelationshipFeature.InterestedInMales = value;
            }
        }

        public bool InterestedInFemales
        {
            get
            {
                return m_RelationshipFeature.InterestedInFemales;
            }
            set
            {
                m_RelationshipFeature.InterestedInFemales = value;
            }
        }

        public bool SameCityLimitPreference
        {
            get
            {
                return m_RelationshipFeature.SameCityLimitPreference;
            }
            set
            {
                m_RelationshipFeature.SameCityLimitPreference = value;
            }
        }

        public int MinAgePreference
        {
            get
            {
                return m_RelationshipFeature.MinAgePreference;
            }
            set
            {
                m_RelationshipFeature.MinAgePreference = value;
            }
        }

        public int MaxAgePreference
        {
            get
            {
                return m_RelationshipFeature.MaxAgePreference;
            }
            set
            {
                m_RelationshipFeature.MaxAgePreference = value;
            }
        }

        public FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
        {
            throwExcpetionIfUsersAreNull();
            FacebookObjectCollection<User> selectedUserFriends = getFriendsFromCacheOrSelectedFriend();
            FacebookObjectCollection<User> matches = new FacebookObjectCollection<User>();
            
            foreach(User friend in selectedUserFriends)
            {
                if (m_RelationshipFeature.IsPotentialMatch(friend))
                {
                    matches.Add(friend);
                }
            }
            
            return matches;
        }

        public bool IsPotentialMatch(User i_Friend)
        {
            return m_RelationshipFeature.IsPotentialMatch(i_Friend);
        }

        private FacebookObjectCollection<User> getFriendsFromCacheOrSelectedFriend()
        {
            FacebookObjectCollection<User> selectedUserFriends;
            bool cacheRetrievalSuccess = m_Cache.TryGetValue(m_RelationshipFeature.SelectedFriend.Id, out selectedUserFriends);

            if (!cacheRetrievalSuccess)
            {
                selectedUserFriends = m_RelationshipFeature.SelectedFriend.Friends;
                m_Cache.Add(m_RelationshipFeature.SelectedFriend.Id, selectedUserFriends);
            }

            return selectedUserFriends;
        }

        private void throwExcpetionIfUsersAreNull()
        {
            if(m_RelationshipFeature.LoggedInUser == null)
            {
                throw new ArgumentNullException("LoggedInUser", "LoggedInUser is null");
            }

            if(m_RelationshipFeature.SelectedFriend == null)
            {
                throw new ArgumentNullException("SelectedFriend", "SelectedFriend is null");
            }
        }
    }
}