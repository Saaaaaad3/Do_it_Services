using Doit.Core.Application.DTO.User.RequestModel;
using Doit.Core.Application.Interfaces.Repository.User;
using Doit.Core.Application.Interfaces.Service.User;
using Doit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Doit.Core.Application.DTO.User.RequestModel.UserReqModel;
using static Doit.Core.Application.DTO.User.ResponseModel.UserResModel;
using Doit.Infrastructure.Extension_Methods;

namespace Doit.Infrastructure.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repo;
        public UserService(IUserRepo userRepo) 
        {
            _repo = userRepo;
        }

        public async Task<LoginRes> Login(UserReqModel.LoginReq loginLequest)
        {
            UserEntity dbReq = new UserEntity
            {
                Username = loginLequest.UserName,
                Password = loginLequest.Password,
            };

            var userIdFromDb = await _repo.Login(dbReq);

            LoginRes response = new LoginRes()
            {
                UserId = userIdFromDb == null ? 0 : Convert.ToInt32(userIdFromDb),
                Token = userIdFromDb.GenerateToken()
            };

            return response;
        }

        public async Task<int> Register(UserReqModel.RegisterReq registerReq)
        {
            UserEntity dbReq = new UserEntity
            {
                FirstName = registerReq.FirstName,
                LastName = registerReq.LastName,
                Username = registerReq.UserName,
                Password = registerReq.Password,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };

            var response = await _repo.Register(dbReq);
            
            return response;
        }
    }
}
