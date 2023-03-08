using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class UpdatedLocationModelMapper
    {
        public static LocationPoint AdaptToLocationPoint(this UpdatedLocationModel p1)
        {
            return p1 == null ? null : new LocationPoint()
            {
                Id = p1.PointId,
                Latitude = p1.Latitude,
                Longitude = p1.Longitude
            };
        }        
    }
}