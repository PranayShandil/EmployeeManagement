using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
