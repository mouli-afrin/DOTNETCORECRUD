//using ASPNETMVCCRUD.Data.Domain;
using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext:DbContext
    {
        public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(am => new
            {
                am.S_Email

            });
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
    


    
    }
}