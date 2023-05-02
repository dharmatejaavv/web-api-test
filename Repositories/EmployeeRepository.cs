using Microsoft.EntityFrameworkCore;
using web_api_test.Models;

namespace web_api_test.Repositories
{
    public class EmployeeRepository : IEmpRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context=context;
        }
        public async Task<Employee> Create(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task Delete(int EmpId)
        {
            var employeeToDelete= await _context.Employees.FindAsync(EmpId);
            _context.Employees.Remove(employeeToDelete);
            await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> Get(int EmpId)
        {
            return await _context.Employees.FindAsync(EmpId);
        }

        public async Task<Employee> Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
