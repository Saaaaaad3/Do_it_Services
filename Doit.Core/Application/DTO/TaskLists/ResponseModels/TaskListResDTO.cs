using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.TaskLists.ResponseModels
{
    public class TaskListResDTO
    {
        public class TaskListInfo
        {
            public long TaskListId { get; set; }
            public long BoardId { get; set; }
            public string TaskListName { get; set; }
            public long Order { get; set; }
        }
    }
}
