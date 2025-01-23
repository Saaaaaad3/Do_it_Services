using Doit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.Interfaces.Repository.TaskCards
{
    public interface ITaskCardRepo
    {
        Task<IEnumerable<TaskEntity>> GetAllTaskCardsByBoardId(long boardId);
    }
}
