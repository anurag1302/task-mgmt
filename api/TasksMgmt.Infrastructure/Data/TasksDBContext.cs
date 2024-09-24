using Microsoft.EntityFrameworkCore;

namespace TasksMgmt.Infrastructure.Data
{
    public class TasksDBContext:DbContext
    {
        public TasksDBContext(DbContextOptions<TasksDBContext> options) : base(options) { 
        }

        public DbSet<Task> Tasks { get; set;}
    }
}
