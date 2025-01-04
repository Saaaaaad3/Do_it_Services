using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Do_it_Services.Controllers.Boards
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly 

        [HttpGet]
        public IActionResult GetAllBoardsByUserId(int UserId)
        {

        }
    }
}
