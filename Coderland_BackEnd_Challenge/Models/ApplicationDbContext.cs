using Microsoft.EntityFrameworkCore;

namespace Coderland_BackEnd_Challenge.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CarBrands> MarcasAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrands>().HasData(
                new CarBrands { Id = 1, Name = "Toyota", CountryOfOrigin = "Japan", FoundationYear = DateTime.SpecifyKind(new DateTime(1937, 8, 28), DateTimeKind.Utc) },
                new CarBrands { Id = 2, Name = "Ford", CountryOfOrigin = "USA", FoundationYear = DateTime.SpecifyKind(new DateTime(1937, 8, 28), DateTimeKind.Utc) },
                new CarBrands { Id = 3, Name = "Chevrolet", CountryOfOrigin = "USA", FoundationYear = DateTime.SpecifyKind(new DateTime(1911, 11, 3), DateTimeKind.Utc) },
                new CarBrands { Id = 4, Name = "Nissan", CountryOfOrigin = "Japan", FoundationYear = DateTime.SpecifyKind(new DateTime(1933, 12, 26), DateTimeKind.Utc) },
                new CarBrands { Id = 5, Name = "BMW", CountryOfOrigin = "Germany", FoundationYear = DateTime.SpecifyKind(new DateTime(1913, 10, 27), DateTimeKind.Utc) },
                new CarBrands { Id = 6, Name = "Changan", CountryOfOrigin = "China", FoundationYear = DateTime.SpecifyKind(new DateTime(1862, 11, 3), DateTimeKind.Utc) }
            );
        }
    }

    public class CarBrands
    {
        public int Id { get; set; }
        public required string  Name { get; set; }
        public string? CountryOfOrigin {  get; set; }
        public DateTime? FoundationYear {  get; set; } 
    }

    

}
