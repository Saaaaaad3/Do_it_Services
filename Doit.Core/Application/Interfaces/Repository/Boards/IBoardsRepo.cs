using Doit.Core.Application.DTO.Boards;
using Doit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doit.Core.Application.DTO.Boards.RequestModels;

namespace Doit.Core.Application.Interfaces.Repository.Boards
{
    public interface IBoardsRepo
    {
        public Task<IEnumerable<BoardEntity>> GetAllBoardsByUserId(long UserId);
        public Task<int> AddBoardAsync(BoardEntity boardReq);
        public Task<int> UpdateBoardName(BoardEntity boardReq);
        public Task<int> RemoveBoard(long boardId);
    }
}
