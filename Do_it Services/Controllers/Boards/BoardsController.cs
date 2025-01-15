using Doit.Core.Application.Interfaces.Service.Boards;
using Microsoft.AspNetCore.Mvc;
using Doit.Core.Application.DTO.Boards.RequestModels;
using System.Reflection.Metadata.Ecma335;
using static Doit.Core.Application.DTO.CommonModel.CommonModel;

namespace Do_it_Services.Controllers.Boards
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardsService _boardsService;

        public BoardsController(IBoardsService boardsService)
        {
            _boardsService = boardsService;
        }

        [HttpGet("GetAllBoardsByUserId")]
        public async Task<IActionResult> GetAllBoardsByUserId(long UserId)
        {
            var response = await _boardsService.GetAllBoardsByUserId(UserId);
            
            return Ok(response);
        }

        [HttpPost("AddNewBoard")]
        public async Task<IActionResult> AddNewBoard([FromBody]BoardsReqDTO.AddBoardReq boardReq)
        {
            var response = await _boardsService.AddBoardAsync(boardReq);

            ReturnModel returnModel = new ReturnModel()
            {
                ReturnCode = response,
                ReturnMessage = "Success"
            };
            return Ok(returnModel);
        }

        [HttpPut("UpdateBoardName")]
        public async Task<IActionResult> UpdateBoardName(BoardsReqDTO.UpdateBoardReq boardReq)
        {
            var response = await _boardsService.UpdateBoardName(boardReq);
            return Ok(response);
        }

        [HttpDelete("RemoveBoard")]
        public async Task<IActionResult> RemoveBoard(long boardId)
        {
            var response = await _boardsService.RemoveBoard(boardId);
            return Ok(response);
        }
    }
}
