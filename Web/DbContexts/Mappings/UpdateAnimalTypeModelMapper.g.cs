using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class UpdateAnimalTypeModelMapper
    {
        public static AnimalType AdaptToAnimalType(this UpdateAnimalTypeModel p1)
        {
            return p1 == null ? null : new AnimalType() {Type = p1.Type, Id = p1.AnimalId};
        }
        
    }
}