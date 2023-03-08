using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class CreateAnimalTypeModelMapper
    {
        public static AnimalType AdaptToAnimalType(this CreateAnimalTypeModel p1)
        {
            return p1 == null ? null : new AnimalType() {Type = p1.Type};
        }
        
    }
}