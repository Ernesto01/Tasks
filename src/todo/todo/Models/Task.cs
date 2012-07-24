using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace todo.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public int? Priority { get; set; }
        public string Description { get; set; }
        public virtual User Owner { get; set; }
    }
}
