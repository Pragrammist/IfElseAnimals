using System.Linq.Expressions;
using Web.DbContexts;
using Web.Models;

namespace Web.DbContexts
{
    public static partial class SearchAccountModelMapper
    {
        public static Func<Acount, bool> BuildSearch(this SearchAccountModel p1, Acount ac)
        {
            Expression<Func<Acount, bool>> searchExpr = c => true;
            var prefix = searchExpr.Compile();
            if(p1.Email is not null)
                searchExpr = c => prefix(c) && p1.Email == ac.Email;
            prefix = searchExpr.Compile();
            if(p1.FirstName is not null)
                searchExpr = c => prefix(c) && p1.FirstName.ToLower() == ac.Email.ToLower();
            prefix = searchExpr.Compile();
            if(p1.LastName is not null)
                searchExpr = c => prefix(c) && p1.LastName.ToLower() == ac.LastName.ToLower();
            prefix = searchExpr.Compile();
            return prefix;
        }
        
    }
}