using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.TaskLists.RequestModels
{
    public class TaskListReqDTO
    {
        public class AddTaskListReq
        {
            public string TaskListName { get; set; }
            public long BoardId { get; set; }
            public int Order { get; set; }
        }

        public class UpdateTaskListReq
        {
            public string TaskListName { get; set; }
            public long BoardId { get; set; }
            public int Order { get; set; }
            public long TaskListId { get; set; }
        }
    }
}
