using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, name = "Kalem 2", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, name = "Kalem 3", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 2, name = "Kitap 1", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 2, name = "Kitap 2", Price = 660, Stock = 32, CreatedDate = DateTime.Now }
            );
        }
    }
}
