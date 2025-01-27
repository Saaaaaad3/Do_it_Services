using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.User.ResponseModel
{
    public class UserResModel
    {
        public class LoginRes
        {
            public int UserId { get; set; }
            public string Token { get; set; }
        }
    }
}
