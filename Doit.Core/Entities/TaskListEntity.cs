using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Core.Entities
{
    public class TaskListEntity
    {
        [Key]
        public long TaskListId { get; set; }
        public long BoardId { get; set; }
        public string TaskListName { get; set; }
        public int Order { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation properties
        public BoardEntity Board { get; set; }
        public ICollection<TaskEntity> Tasks { get; set; }
    }

}
