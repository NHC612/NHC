using Microsoft.EntityFrameworkCore;
using Baithuchanh2003.Models;


namespace Baithuchanh2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}