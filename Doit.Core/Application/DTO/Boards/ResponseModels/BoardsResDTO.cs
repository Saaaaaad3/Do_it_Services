﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Application.DTO.Boards.ResponseModels
{
    public class BoardsResDTO
    {
        public class BoardInfo
        {
            public long BoardId { get; set; }
            public string BoardName { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime ModifiedDate { get; set; }
        }
    }
}
