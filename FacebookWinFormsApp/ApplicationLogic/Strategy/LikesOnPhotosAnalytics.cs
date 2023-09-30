using BasicFacebookFeatures.ApplicationLogic.Decorator;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.ApplicationLogic.Strategy
{
    public class LikesOnPhotosAnalytics : AnalyticsStrategyDecorator
    {
        public LikesOnPhotosAnalytics(IAnalyticsStrategy i_AnalyticsStrategy) : base(i_AnalyticsStrategy)
        {
        }

        public override int GetAnalytics(User i_LoggedInUser, User i_SelectedFriend)
        {
            int analyticsCount = 0;
            int photosCount;
            const int k_PhotosLimitPerAlbum = 10;

            foreach (Album album in i_LoggedInUser.Albums)
            {
                photosCount = 0;

                foreach (Photo photo in album.Photos)
                {
                    if(photosCount >= k_PhotosLimitPerAlbum)
                    {
                        break;
                    }

                    if (photo.LikedBy.Contains(i_SelectedFriend))
                    {
                        analyticsCount++;
                    }

                    photosCount++;
                }
            }

            analyticsCount += AnalyticsStrategy?.GetAnalytics(i_LoggedInUser, i_SelectedFriend) ?? 0;

            return analyticsCount;
        }
    }
}
