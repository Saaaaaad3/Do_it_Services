using Azure;
using Doit.Core.Application.DTO.TaskLists.RequestModels;
using Doit.Core.Application.Interfaces.Repository;
using Doit.Core.Application.Interfaces.Service.TaskLists;
using Doit.Core.Entities;
using static Doit.Core.Application.DTO.TaskLists.ResponseModels.TaskListResDTO;

namespace Doit.Infrastructure.Services.TaskLists
{
    public class TaskListService : ITaskListService
    {
        private readonly ITaskListRepo _taskListRepo;
        public TaskListService(ITaskListRepo taskListRepo)
        {
            _taskListRepo = taskListRepo;
        }

        public async Task<IEnumerable<TaskListInfo>> GetAllTaskListsByBoardId(long boardId)
        {
            var response = await _taskListRepo.GetAllTaskListsByBoardId(boardId);

            return response.Select(b=> new TaskListInfo
            {
                BoardId = b.BoardId,
                Order = b.Order,
                TaskListId = b.TaskListId,
                TaskListName = b.TaskListName
            }).OrderBy(o=>o.Order);
        }

        public async Task<int> AddTaskListAsync(TaskListReqDTO.AddTaskListReq taskListInput)
        {

            TaskListEntity DbReq = new TaskListEntity
            {
                BoardId = taskListInput.BoardId,
                Order = taskListInput.Order,
                TaskListName = taskListInput.TaskListName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };

            var response = await _taskListRepo.AddTaskListAsync(DbReq);
            return response;
        }

        public async Task<int> UpdateTaskList(TaskListReqDTO.UpdateTaskListReq taskListInput)
        {
            TaskListEntity DbReq = new TaskListEntity
            {
                TaskListId = taskListInput.TaskListId,
                Order = taskListInput.Order,
                TaskListName = taskListInput.TaskListName,
            };

            var response = await _taskListRepo.UpdateTaskList(DbReq);
            return response;
        }

        public async Task<int> RemoveTaskList(long taskListId)
        {
            var respnse = await _taskListRepo.RemoveTaskList(taskListId);
            return respnse;
        }
    }
}
