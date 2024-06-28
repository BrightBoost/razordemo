using Microsoft.EntityFrameworkCore;

namespace RazorDemo.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TodoDB");
        }
    }
}
