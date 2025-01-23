using Doit.Core.Application.Interfaces.Repository.TaskCards;
using Doit.Core.Application.Interfaces.Service.TaskCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Doit.Core.Application.DTO.TaskCards.ResponseModel.TaskCardsResModel;

namespace Doit.Infrastructure.Services.TaskCards
{
    public class TaskCardService : ITaskCardService
    {
        private readonly ITaskCardRepo _taskCardRepo;
        public TaskCardService(ITaskCardRepo taskCardRepo)
        {
            _taskCardRepo = taskCardRepo;
        }
        public async Task<IEnumerable<GetTaskCardInfo>> GetAllTaskCardsByBoardId(long boardId)
        {
            var response = await _taskCardRepo.GetAllTaskCardsByBoardId(boardId);

            return response.Select(tc => new GetTaskCardInfo 
            {
                BoardId = tc.BoardId,
                Description = tc.Description,
                Image = tc.Image,
                Order = tc.Order,
                Status = tc.Status,
                TaskListId = tc.TaskListId,
                Title = tc.Title
            });
        }
    }
}
