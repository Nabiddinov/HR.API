using HRDataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace HRDataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbcontext;

        public EmployeeRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            await _dbcontext.Employees.AddAsync(employee);
            await _dbcontext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await _dbcontext.Employees.FindAsync(id);
            if (employee != null)
            {
                _dbcontext.Employees.Remove(employee);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Employee> GetEmployee(int id)
        {
           return await _dbcontext.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _dbcontext.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            var updateEmployee = _dbcontext.Employees.Attach(employee);
            updateEmployee.State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
            return employee;
        }
    }
}
