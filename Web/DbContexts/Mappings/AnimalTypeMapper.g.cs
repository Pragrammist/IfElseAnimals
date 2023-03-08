using Web.DbContexts;

namespace Web.DbContexts
{
    public static partial class AnimalTypeMapper
    {
        public static AnimalTypeModel AdaptToModel(this AnimalType p1)
        {
            return p1 == null ? null : new AnimalTypeModel()
            {
                Id = p1.Id,
                Type = p1.Type
            };
        }
        public static AnimalTypeModel AdaptTo(this AnimalType p2, AnimalTypeModel p3)
        {
            if (p2 == null)
            {
                return null;
            }
            AnimalTypeModel result = p3 ?? new AnimalTypeModel();
            
            result.Id = p2.Id;
            result.Type = p2.Type;
            return result;
            
        }
    }
}