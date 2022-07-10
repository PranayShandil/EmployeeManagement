using EmployeeManagementAPI.Context;
using EmployeeManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeContext _employeeContext { get; }

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_employeeContext.Employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByCode/{employeeCode}")]
        public Employee GetByCode(int employeeCode)
        {
            try
            {
                var employee = _employeeContext.Employees.Find(employeeCode);
                return employee;
            }
            catch (Exception ex)
            {
                //Log ex error
                return new Employee();
            }

        }

        [HttpPost("createorupdate")]
        public IActionResult CreateOrUpdate(Employee employee)
        {
            try
            {
                var emp = _employeeContext.Employees.Find(employee.EmployeeNumber);
                if (emp != null && emp.EmployeeNumber != 0)
                {
                    emp.FirstName = employee.FirstName;
                    emp.LastName = employee.LastName;
                    _employeeContext.Employees.Update(emp);
                }
                else
                    _employeeContext.Employees.Add(employee);

                _employeeContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete/{employeeCode}")]
        public IActionResult Delete(int employeeCode)
        {
            try
            {
                var employee = _employeeContext.Employees.Find(employeeCode);
                _employeeContext.Employees.Remove(employee);
                _employeeContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
