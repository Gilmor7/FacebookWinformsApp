using System;
using System.ComponentModel;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Features.RelationshipFeature
{
    public class RelationshipFeature : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string i_PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
        }

        private const int sr_MinAgeLimit = 18;
        private const int sr_MaxAgeLimit = 120;

        private int m_MinAgePreference = sr_MinAgeLimit;
        private int m_MaxAgePreference = sr_MaxAgeLimit;
        private User m_LoggedInUser;
        private User m_SelectedFriend;
        private bool m_InterestedInMales;
        private bool m_InterestedInFemales;
        private bool m_SameCityLimitPreference;
        private bool m_IsNoMatchesFound;

        public User LoggedInUser
        {
            get => m_LoggedInUser;
            set
            {
                m_LoggedInUser = value;
                OnPropertyChanged(nameof(LoggedInUser));
            }
        }

        public User SelectedFriend
        {
            get => m_SelectedFriend;
            set
            {
                m_SelectedFriend = value;
                OnPropertyChanged(nameof(SelectedFriend));
            }
        }

        public bool InterestedInMales
        {
            get
            {
                return m_InterestedInMales;
            }
            set
            {
                m_InterestedInMales = value;
                OnPropertyChanged(nameof(InterestedInMales));
            }
        }

        public bool InterestedInFemales
        {
            get
            {
                return m_InterestedInFemales;
            }
            set
            {
                m_InterestedInFemales = value;
                OnPropertyChanged(nameof(InterestedInFemales));
            }
        }

        public bool SameCityLimitPreference
        {
            get
            {
                return m_SameCityLimitPreference;
            }
            set
            {
                m_SameCityLimitPreference = value;
                OnPropertyChanged(nameof(SameCityLimitPreference));
            }
        }

        public int MinAgePreference
        {
            get
            {
                return m_MinAgePreference;
            }
            set
            {
                if (value >= sr_MinAgeLimit && value <= sr_MaxAgeLimit)
                {
                    m_MinAgePreference = value;
                    OnPropertyChanged(nameof(MinAgePreference));
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(MinAgePreference));
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
                if (value >= sr_MinAgeLimit && value <= sr_MaxAgeLimit)
                {
                    m_MaxAgePreference = value;
                    OnPropertyChanged(nameof(MaxAgePreference));
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxAgePreference));
                }
            }
        }

        public bool IsNoMatchesFound
        {
            get
            {
                return m_IsNoMatchesFound;
            }
            set
            {
                m_IsNoMatchesFound = value;
                OnPropertyChanged(nameof(IsNoMatchesFound));
            }
        }

        public FacebookObjectCollection<User> PossibleMatches
        {
            get
            {
                FacebookObjectCollection<User> matches;
                try
                {
                    matches = FindMatchesBasedOnPreferences();
                }
                catch (Exception)
                {
                    matches = new FacebookObjectCollection<User>();
                }

                if(matches.Count > 0)
                {
                    IsNoMatchesFound = false;
                }
                else
                {
                    IsNoMatchesFound = true;
                }

                OnPropertyChanged(nameof(PossibleMatches));

                return matches;
            }
        }

        private FacebookObjectCollection<User> FindMatchesBasedOnPreferences()
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
            bool isPreferencedGender = checkGenderPreferences(i_PossibleMatch.Gender);
            bool isHomeTownPreferenceConditionMet = checkSameCityPreference(i_PossibleMatch);
            bool isAgePreferenceMet = checkIfAgePreferenceIsMet(i_PossibleMatch);
            
            return isSingle && isPreferencedGender && isHomeTownPreferenceConditionMet && isAgePreferenceMet;
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