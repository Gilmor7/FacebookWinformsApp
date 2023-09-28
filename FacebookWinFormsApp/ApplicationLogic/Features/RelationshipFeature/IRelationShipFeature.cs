using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature
{
    public interface IRelationShipFeature : IEnumerable<User>
    {
        User LoggedInUser { get; set; }
        User SelectedFriend { get; set; }
        bool InterestedInMales { get; set; }
        bool InterestedInFemales { get; set; }
        bool SameCityLimitPreference { get; set; }
        int MinAgePreference { get; set; }
        int MaxAgePreference { get; set; }
        bool IsPotentialMatch(User i_Friend);
    }
}
