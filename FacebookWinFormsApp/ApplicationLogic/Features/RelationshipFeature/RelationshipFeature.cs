using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Features.RelationshipFeature
{
    public static class RelationshipFeature
    {
        private static readonly int sr_MinAgeLimit = 18;
        private static readonly int sr_MaxAgeLimit = 120;
        
        private static int s_MinAgePreference = sr_MinAgeLimit;
        private static int s_MaxAgePreference = sr_MaxAgeLimit;
        
        public static User LoggedInUser { get; set; } = null;
        public static User SelectedFriend { get; set; } = null;
        public static bool InterestedInMales { get; set; } = false;

        public static bool InterestedInFemales { get; set; } = false;

        public static bool SameCityLimitPreference { get; set; } = false;
        
        public static int MinAgePreference
        {
            get
            {
                return s_MinAgePreference;
            }
            set
            {
                if(value >= sr_MinAgeLimit && value <= sr_MaxAgeLimit)
                {
                    s_MinAgePreference = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MinAgePreference");
                }
            }
        }
        
        public static int MaxAgePreference
        {
            get
            {
                return s_MaxAgePreference;
            }
            set
            {
                if(value >= sr_MinAgeLimit && value <= sr_MaxAgeLimit)
                {
                    s_MaxAgePreference = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MaxAgePreference");
                }
            }
        }

        public static FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
        {
            throwExceptionIfParametersAreNull();
            
            FacebookObjectCollection<User> matches = new FacebookObjectCollection<User>();

            foreach (User possibleMatchUser in SelectedFriend.Friends)
            {
                if(checkIfPossibleMatchIsDistinct(possibleMatchUser) && checkIfMatchPreferencesAreMet(possibleMatchUser))
                {
                    matches.Add(possibleMatchUser);
                }
            }
            
            return matches;
        }

        private static bool checkIfPossibleMatchIsDistinct(User i_PossibleMatchUser)
        {
            bool isPossibleMatchIsTheLoggedInUser = i_PossibleMatchUser.Id == LoggedInUser.Id;
            bool isPossibleMatchInLoggedInUserFriends = LoggedInUser.Friends.Contains(i_PossibleMatchUser);
            
            return !isPossibleMatchIsTheLoggedInUser && !isPossibleMatchInLoggedInUserFriends;
        }

        private static void throwExceptionIfParametersAreNull()
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

        private static bool checkIfMatchPreferencesAreMet(User i_PossibleMatch)
        {
            bool isSingle = i_PossibleMatch.RelationshipStatus == User.eRelationshipStatus.Single;
            bool isPreferencedGender = checkGenderPreferences(i_PossibleMatch.Gender);
            bool isHomeTownPreferenceConditionMet = checkSameCityPreference(i_PossibleMatch);
            bool isAgePreferenceMet = checkIfAgePreferenceIsMet(i_PossibleMatch);
            
            return isSingle && isPreferencedGender && isHomeTownPreferenceConditionMet && isAgePreferenceMet;
        }
        
        private static bool checkGenderPreferences(User.eGender? i_Gender)
        {
            return i_Gender != null && 
                   (InterestedInMales && i_Gender == User.eGender.male ||
                    InterestedInFemales && i_Gender == User.eGender.female);
        }
        
        private static bool checkSameCityPreference(User i_PossibleMatch)
        {
            return !SameCityLimitPreference || i_PossibleMatch.Location.Name == SelectedFriend.Location.Name;
        }
        
        private static bool checkIfAgePreferenceIsMet(User i_PossibleMatch)
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