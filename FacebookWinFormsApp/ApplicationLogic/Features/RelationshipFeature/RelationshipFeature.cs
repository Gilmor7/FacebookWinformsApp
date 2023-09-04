using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature
{
    public class RelationshipFeature : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string i_PropertyName)
        {
            updatePossibleMatchesBasedOnPreferences();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
        }

        private const int k_MinAgeLimit = 18;
        private const int k_MaxAgeLimit = 120;

        private User m_LoggedInUser;
        private User m_SelectedFriend;
        private bool m_IsIntrestedInMale;
        private bool m_IsIntrestedInFemale;
        private bool m_IsIntrestedInSameCity;
        private int m_MinAgePreference = k_MinAgeLimit;
        private int m_MaxAgePreference = k_MaxAgeLimit;
        private FacebookObjectCollection<User> m_PossibleMatches;
        private bool m_NoMatchesFound;

        public int MinAgePreference
        {
            get
            {
                return m_MinAgePreference;
            }
            set
            {
                if (value >= k_MinAgeLimit && value <= k_MaxAgeLimit)
                {
                    if(value > MaxAgePreference)
                    {
                        MaxAgePreference = value;
                    }

                    m_MinAgePreference = value;
                    OnPropertyChanged("MinAgePreference");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MinAgePreference");
                }
            }
        }

        public bool NoMatchesFound
        {
            get
            {
                return m_NoMatchesFound;
            }
            private set
            {
                m_NoMatchesFound = value;
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
                if (value >= k_MinAgeLimit && value <= k_MaxAgeLimit)
                {
                    if(value < MinAgePreference)
                    {
                        m_MaxAgePreference = MinAgePreference;
                    }
                    else
                    {
                        m_MaxAgePreference = value;
                    }

                    OnPropertyChanged("MaxAgePreference");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MaxAgePreference");
                }
            }
        }

        public bool IsIntrestedInMale
        {
            get
            {
                return m_IsIntrestedInMale;
            }

            set
            {
                m_IsIntrestedInMale = value;
                OnPropertyChanged("IsIntrestedInMale");
            }
        }

        public bool IsIntrestedInFemale
        {
            get
            {
                return m_IsIntrestedInFemale;
            }
            
            set
            {
                m_IsIntrestedInFemale = value;
                OnPropertyChanged("IsIntrestedInFemale");
            }
        }

        public bool IsIntrestedInSameCity
        {
            get
            {
                return m_IsIntrestedInSameCity;
            }

            set
            {
                m_IsIntrestedInSameCity = value;
                OnPropertyChanged("IsIntrestedInSameCity");
            }
        }

        public User SelectedFriend
        {
            get
            {
                return m_SelectedFriend;
            }

            set
            {
                m_SelectedFriend = value;
                OnPropertyChanged("SelectedFriend");
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value;
                OnPropertyChanged("LoggedUser");
            }
        }

        public FacebookObjectCollection<User> PossibleMatches
        {
            get
            {
                return m_PossibleMatches;
            }

            private set
            {
                m_PossibleMatches = value;
            }
        }

        private void updatePossibleMatchesBasedOnPreferences()
        {
            FacebookObjectCollection<User> matches;

            if(SelectedFriend == null || LoggedUser == null)
            {
                matches = null;
            }
            else
            {
                matches = new FacebookObjectCollection<User>();

                foreach (User possibleMatchUser in SelectedFriend.Friends)
                {
                    if (checkIfPossibleMatchIsDistinct(possibleMatchUser) && checkIfMatchPreferencesAreMet(possibleMatchUser))
                    {
                        matches.Add(possibleMatchUser);
                    }
                }
            }

            if (matches == null || matches.Count == 0)
            {
                NoMatchesFound = true;
            }
            else
            {
                NoMatchesFound = false;
            }

            PossibleMatches = matches;
        }

        private bool checkIfPossibleMatchIsDistinct(User i_PossibleMatchUser)
        {
            bool isPossibleMatchIsTheLoggedInUser = i_PossibleMatchUser.Id == LoggedUser.Id;
            bool isPossibleMatchInLoggedInUserFriends = LoggedUser.Friends.Contains(i_PossibleMatchUser);

            return !isPossibleMatchIsTheLoggedInUser && !isPossibleMatchInLoggedInUserFriends;
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
                   (IsIntrestedInMale && i_Gender == User.eGender.male ||
                    IsIntrestedInFemale && i_Gender == User.eGender.female);
        }

        private bool checkSameCityPreference(User i_PossibleMatch)
        {
            return !IsIntrestedInSameCity || i_PossibleMatch.Location.Name == SelectedFriend.Location.Name;
        }

        private bool checkIfAgePreferenceIsMet(User i_PossibleMatch)
        {
            bool isAgePreferenceMet = false;

            if (i_PossibleMatch.Birthday != null)
            {
                DateTime birthday = DateTime.Parse(i_PossibleMatch.Birthday);
                int age = DateTime.Today.Year - birthday.Year;
                isAgePreferenceMet = age >= MinAgePreference && age <= MaxAgePreference;
            }

            return isAgePreferenceMet;
        }
    }
}