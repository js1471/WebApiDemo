using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todoitem> TodoItems { get; set; }
    }
}
