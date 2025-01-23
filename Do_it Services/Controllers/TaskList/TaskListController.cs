using Doit.Core.Application.Interfaces.Service.TaskLists;
using Microsoft.AspNetCore.Mvc;
using static Doit.Core.Application.DTO.TaskLists.RequestModels.TaskListReqDTO;

namespace Do_it_Services.Controllers.TaskListController
{
    public class TaskListController : Controller
    {
        private readonly ITaskListService _taskService;

        public TaskListController(ITaskListService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("GetAllTaskListsByBoardId")]
        public async Task<IActionResult> GetAllTaskListsByBoardId(long boardId)
        {
            var response = await _taskService.GetAllTaskListsByBoardId(boardId);
            return Ok(response);
        }

        [HttpPost("AddTaskListAsync")]
        public async Task<IActionResult> AddTaskListAsync(AddTaskListReq taskListInput)
        {
            var response = await _taskService.AddTaskListAsync(taskListInput);
            return Ok(response);
        }

        [HttpPut("UpdateTaskList")]
        public async Task<IActionResult> UpdateTaskList(UpdateTaskListReq updateTaskListInput)
        {
            var response = await _taskService.UpdateTaskList(updateTaskListInput);
            return Ok(response);
        }
        [HttpDelete("RemoveTaskList")]
        public async Task<IActionResult> RemoveTaskList(long taskListId)
        {
            var response = await _taskService.RemoveTaskList(taskListId);
            return Ok(response);
        }
    }
}
