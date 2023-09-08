using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature
{
    public interface IRelationShipFeature
    {
        User LoggedInUser { get; set; }
        User SelectedFriend { get; set; }
        bool InterestedInMales { get; set; }
        bool InterestedInFemales { get; set; }
        bool SameCityLimitPreference { get; set; }
        int MinAgePreference { get; set; }
        int MaxAgePreference { get; set; }
        FacebookObjectCollection<User> FindMatchesBasedOnPreferences();
        bool IsPotentialMatch(User i_Friend);
    }
}
