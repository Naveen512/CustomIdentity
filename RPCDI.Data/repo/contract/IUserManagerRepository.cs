using Microsoft.AspNet.Identity;
using RPCDI.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Data.repo.contract
{
    public interface IUserManagerRepository
    {
        Task<IdentityResult> CreateAsync(CustIdentityUser user, string password);
    }
}
