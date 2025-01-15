using Doit.Core.Application.Interfaces.Repository.Boards;
using Doit.Core.Entities;
using Doit.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Doit.Infrastructure.Repositories.Boards
{
    public class BoardsRepo : IBoardsRepo
    {
        private readonly AppDbContext _context;

        public BoardsRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BoardEntity>> GetAllBoardsByUserId(long userId)
        {
            return await _context.Boards
                .Where(b => b.UserId == userId)
                .ToListAsync();

        }
        public async Task<int> AddBoardAsync(BoardEntity boardReq)
        {
            await _context.Boards.AddAsync(boardReq);
            _context.SaveChanges();
            return 200;

        }
        
        public async Task<int> UpdateBoardName(BoardEntity boardReq)
        {
            var board = await _context.Boards.FirstOrDefaultAsync(b => b.BoardId == boardReq.BoardId);

            if (board != null)
            {
                board.ModifiedDate = DateTime.Now;
                board.BoardName = boardReq.BoardName;
                _context.SaveChanges();
            }

            return 200;

        }
        
        public async Task<int> RemoveBoard(long boardId)
        {
            var board = await _context.Boards.Where(b => b.BoardId == boardId).FirstOrDefaultAsync();
            if (board != null)
            {
                var DBResponse = _context.Boards.Remove(board);
                _context.SaveChanges();
            }

            return 200;

        }
    }
}
