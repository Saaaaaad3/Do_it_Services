using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Doit.Core.Application.DTO.TaskCards.ResponseModel.TaskCardsResModel;

namespace Doit.Core.Application.Interfaces.Service.TaskCards
{
    public interface ITaskCardService
    {
        Task<IEnumerable<GetTaskCardInfo>> GetAllTaskCardsByBoardId(long boardId);

    }
}
