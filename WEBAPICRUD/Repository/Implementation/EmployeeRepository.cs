using Microsoft.EntityFrameworkCore;
using WEBAPICRUD.Models;
using WEBAPICRUD.Repository.Interface;

namespace WEBAPICRUD.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> Add(Employee emp)
        {
            _context.Employees.Add(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<Employee> Update(Employee emp)
        {
            _context.Employees.Update(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<bool> Delete(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            if (emp == null) return false;

            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
