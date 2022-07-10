using EmployeeManagementAPI.Context;
using EmployeeManagementAPI.Data;
using System.Linq;

namespace EmployeeManagementAPI.Seed
{
    public class SeedEmployee
    {
		public static void Seed(EmployeeContext context)
		{
			if (!context.Employees.Any())
			{
				context.Employees.Add(new Employee() { EmployeeNumber = 10, FirstName = "Yuriy", LastName = "Rogach" });
				context.Employees.Add(new Employee() { EmployeeNumber = 30, FirstName = "Peter", LastName = "Ilis" });
				context.Employees.Add(new Employee() { EmployeeNumber = 40, FirstName = "David", LastName = "Björk" });
			}
			context.SaveChanges();
		}
	}
}
