using System.Collections.Concurrent;
using HRDataAccess.Entites;

namespace HRDataAccess
{
    public class MoockEmployeeRepository : IEmployeeRepository
    {
        private static ConcurrentDictionary<int, Employee> _employee = new ConcurrentDictionary<int, Employee>();
        private static object locker = new();

        public MoockEmployeeRepository()
        {
            Init();
        }

        public static void Init()
        {
            _employee.TryAdd(1, new Employee { Id = 1, FullName = "Nabiddinov Abror", Departament = "IT", Email = "nabiddinovabror1@gmail.com" });
            _employee.TryAdd(2, new Employee { Id = 2, FullName = "Sharifov Muhammadali", Departament = "IT", Email = "Sharifov@gmail.com" });
            _employee.TryAdd(3, new Employee { Id = 3, FullName = "Anvar", Departament = "IT", Email = "Anvar@gmail.com" });
            _employee.TryAdd(4, new Employee { Id = 4, FullName = "Javlon", Departament = "IT", Email = "Javlon@gmail.com" });
            _employee.TryAdd(5, new Employee { Id = 5, FullName = "Akhmad", Departament = "IT", Email = "Akhmad@gmail.com" });
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            int newId = 0;
            lock (locker)
            {
                newId = _employee.Keys.Max() + 1;
            }
            employee.Id = newId;
            _employee.TryAdd(newId, employee);
            return await Task.FromResult(employee);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await Task.FromResult(_employee.Values);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await Task.FromResult(_employee[id]);
        }

        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            await Task.FromResult(_employee[id] = employee);
            return employee;
        }

        public Task<bool> DeleteEmployee(int id)
        {
            if (_employee.ContainsKey(id))
            {
                _employee.TryRemove(id, out _);
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
    }
}