using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.Boards.RequestModels
{
    public class BoardsReqDTO
    {
        public class AddBoardReq
        {
            public long UserId { get; set; }
            public string BoardName { get; set; }
        }

        public class UpdateBoardReq
        {
            public long BoardId{ get; set; }
            public string NewBoardName { get; set; }
        }
    }
}
