using EmployeeManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagementAPI.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
