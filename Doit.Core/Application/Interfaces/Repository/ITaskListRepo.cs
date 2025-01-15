using Doit.Core.Entities;

namespace Doit.Core.Application.Interfaces.Repository
{
    public interface ITaskListRepo
    {
        Task<IEnumerable<TaskListEntity>> GetAllTaskListsByBoardId(long boardId);
        Task<int> AddTaskListAsync(TaskListEntity taskListInput);
        Task<int> UpdateTaskList(TaskListEntity taskListInput);
        Task<int> RemoveTaskList(long taskListId);
    }
}
