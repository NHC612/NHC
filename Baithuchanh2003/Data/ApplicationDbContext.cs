using BaiThucHanh0703.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh0703.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}