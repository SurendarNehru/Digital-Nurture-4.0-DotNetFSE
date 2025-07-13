using Microsoft.AspNetCore.Mvc;
using WebApiLab3and4.Models;    
using WebApiLab3and4.Filters;    


namespace WebApiLab3and4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();

        public EmployeeController()
        {
            if (!employees.Any())
                employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "sanz",
                    Salary = 80000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> { new Skill { Id = 1, SkillName = "C#" } },
                    DateOfBirth = new DateTime(2004, 10, 28)
                }
            };
        }

        [HttpGet("getstandard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updated)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = updated.Name;
            emp.Salary = updated.Salary;
            emp.Permanent = updated.Permanent;
            emp.Department = updated.Department;
            emp.Skills = updated.Skills;
            emp.DateOfBirth = updated.DateOfBirth;

            return Ok(emp);
        }

        [HttpGet("throwexception")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ThrowException()
        {
            throw new Exception("This is a test exception.");
        }
    }
}
