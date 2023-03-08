using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class AcountMapper
    {
        public static AccountModel AdaptToAccountModel(this Acount p1)
        {
            return p1 == null ? null : new AccountModel()
            {
                Id = p1.Id,
                FirstName = p1.FirstName,
                LastName = p1.LastName,
                Email = p1.Email
            };
        }
        
    }
}