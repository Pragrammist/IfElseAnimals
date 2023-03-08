using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class CreateLocationModelMapper
    {
        public static LocationPoint AdaptToLocationPoint(this CreateLocationModel p1)
        {
            return p1 == null ? null : new LocationPoint()
            {
                Latitude = p1.Latitude,
                Longitude = p1.Longitude
            };
        }
        
    }
}