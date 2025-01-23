using Doit.Core.Application.Interfaces.Repository.TaskCards;
using Doit.Core.Entities;
using Doit.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Infrastructure.Repositories.TaskCards
{
    public class TaskCardRepo : ITaskCardRepo
    {
       private readonly AppDbContext _context;
        public TaskCardRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TaskEntity>> GetAllTaskCardsByBoardId(long boardId)
        {
            var DbResponse = await _context.Tasks.Where(tc=> tc.BoardId == boardId).ToListAsync();

            return DbResponse;
        }
    }
}
