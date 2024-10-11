using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.ToDoItemDbContext
{
    public class TodoItemDbContext : DbContext
    {

        public TodoItemDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<TodoItem> items { get; set; }
    }
}
