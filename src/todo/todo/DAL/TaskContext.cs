using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace todo.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}