using Microsoft.EntityFrameworkCore;
using TasksMgmt.Core.Entities;

namespace TasksMgmt.Infrastructure.Data
{
    public class TasksDBContext:DbContext
    {
        public TasksDBContext(DbContextOptions<TasksDBContext> options) : base(options) { 
        }

        public DbSet<User> Users { get; set;}
    }
}
