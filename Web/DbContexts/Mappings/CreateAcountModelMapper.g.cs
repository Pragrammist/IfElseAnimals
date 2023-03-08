using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class CreateAcountModelMapper
    {
        public static Acount AdaptToAcount(this CreateAcountModel p1)
        {
            return p1 == null ? null : new Acount()
            {
                FirstName = p1.FirstName,
                LastName = p1.LastName,
                Email = p1.Email,
                Password = p1.Password
            };
        }
    }
}