using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        } 

        public DbSet<Employee> Employee { get; set; }
    }
}