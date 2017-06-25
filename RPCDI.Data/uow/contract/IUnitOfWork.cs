using RPCDI.Data.repo.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCDI.Data.uow.contract
{
    public interface IUnitOfWork
    {
        IUserManagerRepository UserManagerRepository { get;}
    }
}
