using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Entities
{
    public class BoardEntity
    {
        [Key]
        public long BoardId { get; set; }
        public string BoardName { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation properties
        public UserEntity User { get; set; }
        public ICollection<TaskListEntity> TaskLists { get; set; }
    }

}
