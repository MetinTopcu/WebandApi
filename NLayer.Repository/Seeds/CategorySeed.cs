using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        // Seed'in amacı databasede oluşturulan tablodaki yerlere default değerler atamak
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Sadece id yi Seed data ile oluştururken değerini veriyoruz
            builder.HasData(new Category { Id = 1, name = "Kalemler" },
                new Category { Id = 2, name = "Kitaplar" },
                new Category { Id = 3, name = "Defterler" });
        }
    }
}
