using Doit.Core.Application.DTO.User.RequestModel;
using Doit.Core.Application.Interfaces.Service.User;
using Microsoft.AspNetCore.Mvc;
using static Doit.Core.Application.DTO.User.RequestModel.UserReqModel;

namespace Do_it_Services.Controllers.User
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterReq registerReq)
        {
            var response = await _userService.Register(registerReq);
            return Ok(new { resultCode = response });
        }
        [HttpGet("Login")]
        public async Task<IActionResult> Login(LoginReq loginReq)
        {
            var response = await _userService.Login(loginReq);
            return Ok(new { resultCode = response });
        }
    }
}
