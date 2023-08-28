using HRDataAccess.Entites;

namespace HRDataAccess
{
    public interface IAdressRepository
    {
        Task<Adress> CreateAdress(Adress adress);
        Task<IEnumerable<Adress>> GetAdresses();
        Task<Adress> GetAdress(int id);
        Task<Adress> UpdateAdress(int id, Adress adress);
        Task<bool> DeleteAdress(int id);
    }
}