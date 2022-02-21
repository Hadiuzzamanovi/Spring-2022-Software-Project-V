using demoWebAppclass1.Models;
using Microsoft.EntityFrameworkCore;

namespace demoWebAppclass1.DBContexts
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; } 


    }
}
