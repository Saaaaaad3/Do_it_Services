using Doit.Core.Application.Interfaces.Repository.Boards;
using Doit.Core.Application.Interfaces.Service.Boards;
using Doit.Core.Application.DTO.Boards.RequestModels;
using Doit.Core.Application.DTO.Boards.ResponseModels;
using Doit.Core.Entities;

namespace Doit.Infrastructure.Services.Boards
{
    public class BoardsService : IBoardsService
    {
        private readonly IBoardsRepo _boardsRepo;
        public BoardsService(IBoardsRepo boardsRepo)
        {
            _boardsRepo = boardsRepo;
        }

        public async Task<IEnumerable<BoardsResDTO.BoardInfo>> GetAllBoardsByUserId(long UserId)
        {
            var boardsFromDB = await _boardsRepo.GetAllBoardsByUserId(UserId);

            return boardsFromDB.Select(b => new BoardsResDTO.BoardInfo
            {
                BoardId = b.BoardId,
                BoardName = b.BoardName,
                CreatedDate = b.CreatedDate,
                ModifiedDate = b.ModifiedDate,
            });
        }

        public async Task<int> AddBoardAsync(BoardsReqDTO.AddBoardReq boardReq)
        {
            BoardEntity DBRequest = new BoardEntity
            {
                UserId = boardReq.UserId,
                BoardName = boardReq.BoardName,
                CreatedDate = DateTime.Now,
                ModifiedDate= DateTime.Now
            };

            var addResult = await _boardsRepo.AddBoardAsync(DBRequest);

            return 200;
        }

        public async Task<int> UpdateBoardName(BoardsReqDTO.UpdateBoardReq boardReq)
        {
            BoardEntity DBRequest = new BoardEntity
            {
                BoardId = boardReq.BoardId,
                BoardName = boardReq.NewBoardName
            };

            var addResult = await _boardsRepo.UpdateBoardName(DBRequest);

            return 200;
        }

        public async Task<int> RemoveBoard(long boardId)
        {
            await _boardsRepo.RemoveBoard(boardId);
            return 200;
        }

    }
}
