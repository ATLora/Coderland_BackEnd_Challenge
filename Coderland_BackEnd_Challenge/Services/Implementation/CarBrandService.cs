// CarBrandService.cs
using Coderland_BackEnd_Challenge.Models;
using Coderland_BackEnd_Challenge.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

public class CarBrandService : ICarBrandService
{
    private readonly ApplicationDbContext _db;

    public CarBrandService(ApplicationDbContext context)
    {
        _db = context;
    }

    public async Task<IEnumerable<CarBrands>> GetAllMarcasAsync()
    {
        return await _db.MarcasAutos.ToListAsync();
    }

    public async Task<CarBrands> GetMarcaByIdAsync(int id)
    {
        return await _db.MarcasAutos.FindAsync(id);
    }

    public async Task<CarBrands> CreateMarcaAsync(CarBrands marca)
    {
        await _db.MarcasAutos.AddAsync(marca);
        await _db.SaveChangesAsync();
        return marca; // Retorna la marca creada
    }

    public async Task<bool> UpdateMarcaAsync(CarBrands marca)
    {
        var existingMarca = await _db.MarcasAutos.FindAsync(marca.Id);
        if (existingMarca == null) return false;

        existingMarca.Name = marca.Name;
        existingMarca.CountryOfOrigin = marca.CountryOfOrigin;
        existingMarca.FoundationYear = marca.FoundationYear;

        _db.MarcasAutos.Update(existingMarca);
        await _db.SaveChangesAsync();
        return true; // Retorna verdadero si la actualización fue exitosa
    }

    public async Task<bool> DeleteMarcaAsync(int id)
    {
        var existingMarca = await _db.MarcasAutos.FindAsync(id);
        if (existingMarca == null) return false;

        _db.MarcasAutos.Remove(existingMarca);
        await _db.SaveChangesAsync();
        return true; // Retorna verdadero si la eliminación fue exitosa
    }
}
