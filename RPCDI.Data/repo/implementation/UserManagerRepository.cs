using Microsoft.AspNet.Identity;
using RPCDI.Data.repo.contract;
using RPCDI.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Data.repo.implementation
{
    public class UserManagerRepository : UserManager<CustIdentityUser>,IUserManagerRepository
    {
        public UserManagerRepository(IUserStore<CustIdentityUser> store) : base(store)
        {
        }

        public override async Task<IdentityResult> CreateAsync(CustIdentityUser user, string password)
        {
            return await base.CreateAsync(user, password);
        }
    }
}
