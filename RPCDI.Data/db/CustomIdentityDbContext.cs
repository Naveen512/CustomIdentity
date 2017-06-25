using Microsoft.AspNet.Identity.EntityFramework;
using RPCDI.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RPCDI.Data.db
{
    public class CustomIdentityDbContext:IdentityDbContext<CustIdentityUser,CustIdentityRole,string,CustIdentityUserLogin,CustIdentityUserRole,CustIdentityUserClaim>
    {
        public CustomIdentityDbContext(string connectionString):base(connectionString)
        {
            
        }
        
        
    }
}
