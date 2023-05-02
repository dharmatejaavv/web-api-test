using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_test.Models;
using web_api_test.Repositories;

namespace web_api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmpRepository _empRepository;

        public EmployeesController(IEmpRepository empRepository) {
        _empRepository=empRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _empRepository.Get();
        }
        [HttpGet("EmpId")]
        public async Task<ActionResult<Employee>> GetEmployees(int EmpId)
        {
            return await _empRepository.Get(EmpId);
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployees([FromBody] Employee employee)
        {
            var newEmployee= await _empRepository.Create(employee);
            return CreatedAtAction(nameof(GetEmployees), new { EmpId = newEmployee.EmpId },newEmployee);
        }
        [HttpPut]
        public async Task<ActionResult> PutEmployees(int EmpId, [FromBody] Employee employee)
        {
            if(EmpId!=employee.EmpId)
            {
                return BadRequest();
            }
            await _empRepository.Update(employee);
            return NoContent();
        }
        [HttpDelete("EmpId")]
        public async Task<ActionResult> Delete(int EmpId)
        {
            var employeeToDelete = await _empRepository.Get(EmpId);
            if(employeeToDelete==null)
            {
                return NotFound();
            }
            await _empRepository.Delete(employeeToDelete.EmpId);
            return NoContent();
        }

    }
}
