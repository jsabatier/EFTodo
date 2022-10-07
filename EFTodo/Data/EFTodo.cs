using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class TodoContext : DbContext
{
   public DbSet<Todo> Todo{get;set;}
   public string DbPath {get; private set;} 

   public TodoContext()
    {
        // Path to SQLite database file
        DbPath = "EFTodo.db";
    }
    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}