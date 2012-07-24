using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}