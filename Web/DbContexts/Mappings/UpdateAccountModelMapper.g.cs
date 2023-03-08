using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class UpdateAccountModelMapper
    {
        public static void UpdateEntity(this UpdateAccountModel p2, Acount p3)
        {            
            p3.FirstName = p2.FirstName ?? p3.FirstName;
            p3.LastName = p2.LastName ?? p3.LastName;
            p3.Email = p2.Email ?? p3.Email;
            p3.Password = p2.Password ?? p3.Password;
            
            
        }
    }
}