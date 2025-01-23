using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.TaskCards.ResponseModel
{
    public class TaskCardsResModel
    {
        public class GetTaskCardInfo
        {
            public long TaskListId { get; set; }
            public long BoardId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public int Order { get; set; }
            public string Status { get; set; }
        }
    }
}
