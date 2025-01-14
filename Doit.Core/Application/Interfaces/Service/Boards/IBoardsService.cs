using Doit.Core.Application.DTO.Boards.ResponseModels;
using Doit.Core.Application.DTO.Boards.RequestModels;

namespace Doit.Core.Application.Interfaces.Service.Boards
{
    public interface IBoardsService
    {
        public Task<IEnumerable<BoardsResDTO.BoardInfo>> GetAllBoardsByUserId(long UserId);
        public Task<int> AddBoardAsync(BoardsReqDTO.AddBoardReq boardReq);
        public Task<int> UpdateBoardName(BoardsReqDTO.UpdateBoardReq boardReq);
        public Task<int> RemoveBoard(long boardId);
    }
}
