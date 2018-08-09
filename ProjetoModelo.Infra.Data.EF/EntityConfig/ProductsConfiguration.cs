using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class ProductsConfiguration : EntityTypeConfiguration<Products>
    {
        public ProductsConfiguration()
        {
            HasKey(p => p.ProductID);
            Property(p => p.ProductName).HasColumnType("nvarchar").HasMaxLength(40).IsRequired();
            Property(p => p.SupplierID).IsOptional();
            Property(p => p.CategoryID).IsOptional();
            Property(p => p.QuantityPerUnit).HasColumnType("nvarchar").HasMaxLength(20).IsOptional();
            Property(p => p.Discontinued).IsRequired();

            HasMany(p => p.OrderDetails)
                .WithRequired(p => p.Products)
                .HasForeignKey(p => p.ProductID);
        }
    }
}
