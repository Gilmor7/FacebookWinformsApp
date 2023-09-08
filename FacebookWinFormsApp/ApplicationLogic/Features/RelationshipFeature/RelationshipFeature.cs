using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature
{
    public class RelationshipFeature
    {
        private const int k_MinAgeLimit = 18;
        private const int k_MaxAgeLimit = 120;
        
        private int m_MinAgePreference = k_MinAgeLimit;
        private int m_MaxAgePreference = k_MaxAgeLimit;
        public User LoggedInUser { get; set; } = null;
        public User SelectedFriend { get; set; } = null;
        public bool InterestedInMales { get; set; } = false;
        public bool InterestedInFemales { get; set; } = false;
        public bool SameCityLimitPreference { get; set; } = false;
        
        public int MinAgePreference
        {
            get
            {
                return m_MinAgePreference;
            }
            set
            {
                if(value >= k_MinAgeLimit && value <= k_MaxAgeLimit)
                {
                    m_MinAgePreference = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MinAgePreference");
                }
            }
        }
        
        public int MaxAgePreference
        {
            get
            {
                return m_MaxAgePreference;
            }
            set
            {
                if(value >= k_MinAgeLimit && value <= k_MaxAgeLimit)
                {
                    m_MaxAgePreference = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MaxAgePreference");
                }
            }
        }

        public FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
        {
            throwExceptionIfParametersAreNull();
            
            FacebookObjectCollection<User> matches = new FacebookObjectCollection<User>();

            foreach (User possibleMatchUser in SelectedFriend.Friends)
            {
                if(IsPotentialMatch(possibleMatchUser))
                {
                    matches.Add(possibleMatchUser);
                }
            }
            
            return matches;
        }
        
        public bool IsPotentialMatch(User i_PossibleMatch)
        {
            User previousSelectedFriend = SelectedFriend;
            SelectedFriend = i_PossibleMatch;
            throwExceptionIfParametersAreNull();
            
            bool isPotentialMatch = checkIfPossibleMatchIsDistinct(i_PossibleMatch) && checkIfMatchPreferencesAreMet(i_PossibleMatch);
            SelectedFriend = previousSelectedFriend;

            return isPotentialMatch;
        }

        private bool checkIfPossibleMatchIsDistinct(User i_PossibleMatchUser)
        {
            bool isPossibleMatchIsTheLoggedInUser = i_PossibleMatchUser.Id == LoggedInUser.Id;
            bool isPossibleMatchInLoggedInUserFriends = LoggedInUser.Friends.Contains(i_PossibleMatchUser);
            
            return !isPossibleMatchIsTheLoggedInUser && !isPossibleMatchInLoggedInUserFriends;
        }

        private void throwExceptionIfParametersAreNull()
        {
            if(LoggedInUser == null)
            {
                throw new ArgumentNullException("LoggedInUser");
            }
            
            if(SelectedFriend == null)
            {
                throw new ArgumentNullException("SelectedFriend");
            }
        }

        private bool checkIfMatchPreferencesAreMet(User i_PossibleMatch)
        {
            bool isSingle = i_PossibleMatch.RelationshipStatus == User.eRelationshipStatus.Single;
            bool isPreferenceGender = checkGenderPreferences(i_PossibleMatch.Gender);
            bool isHomeTownPreferenceConditionMet = checkSameCityPreference(i_PossibleMatch);
            bool isAgePreferenceMet = checkIfAgePreferenceIsMet(i_PossibleMatch);
            
            return isSingle && isPreferenceGender && isHomeTownPreferenceConditionMet && isAgePreferenceMet;
        }
        
        private bool checkGenderPreferences(User.eGender? i_Gender)
        {
            return i_Gender != null && 
                   (InterestedInMales && i_Gender == User.eGender.male ||
                    InterestedInFemales && i_Gender == User.eGender.female);
        }
        
        private bool checkSameCityPreference(User i_PossibleMatch)
        {
            return !SameCityLimitPreference || i_PossibleMatch.Location.Name == SelectedFriend.Location.Name;
        }
        
        private bool checkIfAgePreferenceIsMet(User i_PossibleMatch)
        {
            bool isAgePreferenceMet = false;
            
            if(i_PossibleMatch.Birthday != null)
            {
                DateTime birthday = DateTime.Parse(i_PossibleMatch.Birthday);
                int age = DateTime.Today.Year - birthday.Year;
                isAgePreferenceMet = age >= MinAgePreference && age <= MaxAgePreference;
            }
            
            return isAgePreferenceMet;
        }
    }
}