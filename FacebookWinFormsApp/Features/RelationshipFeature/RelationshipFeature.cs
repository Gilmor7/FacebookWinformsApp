using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Features.RelationshipFeature
{
    public static class RelationshipFeature
    {
        public static User SelectedFriend { get; set; }
        public static bool InterestedInMales { get; set; }
        public static bool InterestedInFemales { get; set; }
        public static int MinAgePreference { get; set; }
        public static int MaxAgePreference { get; set; }
        public static bool SameCityLimitPreference { get; set; }

        public static FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
        {
            throwExceptionIfSelectedFriendIsNull();
            
            FacebookObjectCollection<User> matches = new FacebookObjectCollection<User>();

            foreach (User possibleMatchUser in SelectedFriend.Friends)
            {
                if(checkIfMatchPreferencesAreMet(possibleMatchUser))
                {
                    matches.Add(possibleMatchUser);
                }
            }
            
            return matches;
        }
        
        private static void throwExceptionIfSelectedFriendIsNull()
        {
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

        public static bool IsAgeRangeValid()
        {
            return MaxAgePreference > MinAgePreference;
        }
    }
}