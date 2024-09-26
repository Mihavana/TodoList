using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.ToDoItemDbContext
{
    public class TodoItemDbContext : DbContext
    {
        public DbSet<TodoItem> items { get; set; }

        public TodoItemDbContext(DbContextOptions<TodoItemDbContext> options)
            :base(options)
        {

        }
    }
}
