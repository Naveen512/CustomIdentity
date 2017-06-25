using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Infrastructure.User
{
    public class CustIdentityUser:IdentityUser<string,CustIdentityUserLogin,CustIdentityUserRole,CustIdentityUserClaim>
    {
        public override string Id
        {
            get; set;
        } = new Guid().ToString();
        public string LandPhone { get; set; }
    }
}
