using HRDataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace HRDataAccess
{
    public class AdressRepository : IAdressRepository
    {
        private readonly AppDbContext _dbcontext;

        public AdressRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Adress> CreateAdress(Adress adress)
        {
            await _dbcontext.Adresses.AddAsync(adress);
            await _dbcontext.SaveChangesAsync();
            return adress;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            await _dbcontext.Employees.AddAsync(employee);
            await _dbcontext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteAdress(int id)
        {
            var adress = await _dbcontext.Adresses.FindAsync(id);
            if (adress != null)
            {
                _dbcontext.Adresses.Remove(adress);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Adress> GetAdress(int id)
        {
            return await _dbcontext.Adresses.FindAsync(id);
        }

        public async Task<IEnumerable<Adress>> GetAdresses()
        {
            return await _dbcontext.Adresses.ToListAsync();
        }

        public async Task<Adress> UpdateAdress(int id, Adress adress)
        {
            var updateAdress = _dbcontext.Adresses.Attach(adress);
            updateAdress.State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
            return adress;
        }
    }
}