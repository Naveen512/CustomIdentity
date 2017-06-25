using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Infrastructure.User
{
    public class CustIdentityRole:IdentityRole<string,CustIdentityUserRole>
    {
        public string RoleNickName { get; set; }
    }
}
