using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Doit.Core.Application.DTO.User.RequestModel.UserReqModel;
using static Doit.Core.Application.DTO.User.ResponseModel.UserResModel;

namespace Doit.Core.Application.Interfaces.Service.User
{
    public interface IUserService
    {
        Task<int> Register(RegisterReq request);
        Task<LoginRes> Login(LoginReq request);
    }
}
