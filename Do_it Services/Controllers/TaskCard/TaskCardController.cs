using Doit.Core.Application.Interfaces.Service.TaskCards;
using Microsoft.AspNetCore.Mvc;

namespace Do_it_Services.Controllers.TaskCard
{
    public class TaskCardController : Controller
    {
        private readonly ITaskCardService _taskCardService;

        public TaskCardController(ITaskCardService taskCardService)
        {
            _taskCardService = taskCardService;
        }

        [HttpGet("GetAllTaskCardsByBoardId")]
        public async Task<IActionResult> GetAllTaskCardsByBoardId(long boardId)
        {
            var response = await _taskCardService.GetAllTaskCardsByBoardId(boardId);

            return Ok(response);
        }
    }
}
