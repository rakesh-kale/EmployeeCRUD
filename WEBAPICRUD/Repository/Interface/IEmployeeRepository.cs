using WEBAPICRUD.Models;

namespace WEBAPICRUD.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee emp);
        Task<Employee> Update(Employee emp);
        Task<bool> Delete(int id);
    }
}
