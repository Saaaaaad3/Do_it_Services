using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.User.RequestModel
{
    public class UserReqModel
    {
        public class RegisterReq
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class LoginReq
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
