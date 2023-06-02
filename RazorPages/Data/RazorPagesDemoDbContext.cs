using Microsoft.EntityFrameworkCore;
using RazorPages.Models.Domain;

namespace RazorPages.Data
{
    public class RazorPagesDemoDbContext : DbContext
    {
        public RazorPagesDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
