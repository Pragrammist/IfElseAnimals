using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class LocationPointMapper
    {
        public static LocationPointModel AdaptToModel(this LocationPoint p1)
        {
            return p1 == null ? null : new LocationPointModel()
            {
                Id = p1.Id,
                Latitude = p1.Latitude,
                Longitude = p1.Longitude
            };
        }
        public static LocationPointModel AdaptTo(this LocationPoint p2, LocationPointModel p3)
        {
            if (p2 == null)
            {
                return null;
            }
            LocationPointModel result = p3 ?? new LocationPointModel();
            
            result.Id = p2.Id;
            result.Latitude = p2.Latitude;
            result.Longitude = p2.Longitude;
            return result;
            
        }
    }
}