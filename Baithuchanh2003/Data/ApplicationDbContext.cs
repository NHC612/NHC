using Baithuchanh2003.Models;
using Microsoft.EntityFrameworkCore;

namespace Baithuchanh2003.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
        public DbSet<Employee> Employee {get;set;  }
        public DbSet<Customer> Customer {get;set;  }
        public DbSet<Person> Person {get;set; }
    }
