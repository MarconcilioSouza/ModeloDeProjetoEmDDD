using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class CategoriesConfiguration : EntityTypeConfiguration<Categories>
    {
        public CategoriesConfiguration()
        {
            HasKey(p => p.CategoryID);
            Property(p => p.CategoryName).HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(p => p.Description).HasColumnType("ntext").HasMaxLength(400).IsOptional();
            Property(p => p.Picture).HasColumnType("image").IsOptional();

            ToTable("Categories");

            HasMany(p => p.Products)
                .WithOptional(p => p.Categories);
        }
    }
}
