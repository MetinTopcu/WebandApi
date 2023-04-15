using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;


namespace NLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {       
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            // Veritabanı işleri kim id kim foreign key mesela 2.satır Id birer birer artsın 3. de en fazla 200 karakter uzunluğu,
            // hasone x.category olan son satırda category bir tane olabilir ama ürün categoride n tane olabilir diyor bide foreign key

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();

            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.ToTable("Products");
            //foreign key e standart isimler kullanırsak gerek yok totable diyip başlığı yazdığımız şeye de gerek yok
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            
        }


    }
}
