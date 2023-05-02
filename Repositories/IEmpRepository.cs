using web_api_test.Models;

namespace web_api_test.Repositories
{
    public interface IEmpRepository
    {
        Task<IEnumerable<Employee>> Get();
        Task<Employee> Get(int EmpId);
        Task<Employee> Create(Employee employee);
        Task<Employee> Update(Employee employee);
        Task Delete(int EmpId);
    }
}
