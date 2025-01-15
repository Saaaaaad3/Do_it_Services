using Doit.Core.Application.Interfaces.Repository;
using Doit.Core.Entities;
using Doit.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Doit.Infrastructure.Repositories.TaskLists
{
    public class TaskListRepo : ITaskListRepo
    {
        private readonly AppDbContext _context;
        public TaskListRepo(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<IEnumerable<TaskListEntity>> GetAllTaskListsByBoardId(long boardId)
        {
            return await _context.TaskLists.Where(b => b.BoardId == boardId).ToListAsync();
        }

        public async Task<int> AddTaskListAsync(TaskListEntity taskListInput)
        {
            await _context.AddAsync(taskListInput);
            _context.SaveChanges();
            return 200;
        }

        public async Task<int> UpdateTaskList(TaskListEntity taskListInput)
        {
            var taskList = await _context.TaskLists.FirstOrDefaultAsync(tl => tl.TaskListId == taskListInput.TaskListId);

            if(taskList != null)
            {
                taskList.TaskListName = taskListInput.TaskListName;
                taskList.Order = taskListInput.Order;
                taskList.ModifiedDate = DateTime.Now;
                _context.SaveChanges();
            }
            return 200;
        }

        public async Task<int> RemoveTaskList(long taskListId)
        {
            var taskList = await _context.TaskLists.FirstOrDefaultAsync(tl => tl.TaskListId == taskListId);
            if (taskList != null)
            {
                var DBResponse = _context.TaskLists.Remove(taskList);
                _context.SaveChanges();
            }
            return 200;
        }
    }
}
