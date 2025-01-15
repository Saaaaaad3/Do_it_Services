using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Doit.Core.Application.DTO.TaskLists.RequestModels.TaskListReqDTO;
using static Doit.Core.Application.DTO.TaskLists.ResponseModels.TaskListResDTO;

namespace Doit.Core.Application.Interfaces.Service.TaskLists
{
    public interface ITaskListService
    {
        Task<IEnumerable<TaskListInfo>> GetAllTaskListsByBoardId(long boardId);
        Task<int> AddTaskListAsync(AddTaskListReq taskListInput);
        Task<int> UpdateTaskList(UpdateTaskListReq taskListInput);
        Task<int> RemoveTaskList(long taskListId);

    }
}
