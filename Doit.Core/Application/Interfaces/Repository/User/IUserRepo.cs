using Doit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.Interfaces.Repository.User
{
    public interface IUserRepo
    {
        Task<int> Register(UserEntity userDbReq);
        Task<long?> Login(UserEntity userDbReq);
    }
}
