using Microsoft.EntityFrameworkCore;
using TodoApp2.Models;

namespace TodoApp2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<TodoItem> TodoItems { get; set; }
}