using Coderland_BackEnd_Challenge.Models;

namespace Coderland_BackEnd_Challenge.Services.Interfaces
{
    public interface ICarBrandService
    {
        Task<IEnumerable<CarBrands>> GetAllMarcasAsync();
        Task<CarBrands> GetMarcaByIdAsync(int id);
        Task<CarBrands> CreateMarcaAsync(CarBrands marca);
        Task<bool> UpdateMarcaAsync(CarBrands marca);
        Task<bool> DeleteMarcaAsync(int id);
    }
}
