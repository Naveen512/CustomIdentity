using Microsoft.AspNet.Identity.EntityFramework;
using RPCDI.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace RPCDI.Data.db
{
    public class CustUserStore : UserStore<CustIdentityUser, CustIdentityRole, string, CustIdentityUserLogin, CustIdentityUserRole, CustIdentityUserClaim>,IUserStore<CustIdentityUser>
    {
        public CustUserStore(DbContext context) : base(context)
        {
        }
    }
}
