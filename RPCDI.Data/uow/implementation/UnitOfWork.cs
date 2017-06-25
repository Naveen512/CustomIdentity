using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RPCDI.Data.db;
using RPCDI.Data.repo.contract;
using RPCDI.Data.repo.implementation;
using RPCDI.Data.uow.contract;
using RPCDI.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Data.uow.implementation
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CustomIdentityDbContext _identity = null;
        private readonly IUserStore<CustIdentityUser> _userStore = null;
        private IUserManagerRepository _userManagerRepository = null;
        public UnitOfWork(CustomIdentityDbContext identity)
        {
            _identity = identity;
            _userStore = new CustUserStore(_identity);
        }

        public IUserManagerRepository UserManagerRepository
        {
            get
            {
                if (_userManagerRepository == null)
                    _userManagerRepository = new UserManagerRepository(_userStore);
                return _userManagerRepository;
            }
        }
    }
}
