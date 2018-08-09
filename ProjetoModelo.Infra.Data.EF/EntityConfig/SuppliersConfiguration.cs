using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class SuppliersConfiguration : EntityTypeConfiguration<Suppliers>
    {
        public SuppliersConfiguration()
        {
            HasKey(p => p.SupplierID);
            Property(p => p.CompanyName).HasMaxLength(40).IsRequired();
            Property(p => p.ContactName).HasMaxLength(30).IsOptional();
            Property(p => p.ContactTitle).HasMaxLength(30).IsOptional();
            Property(p => p.Address).HasMaxLength(60).IsOptional();
            Property(p => p.City).HasMaxLength(15).IsOptional();
            Property(p => p.Region).HasMaxLength(15).IsOptional();
            Property(p => p.Country).HasMaxLength(15).IsOptional();
            Property(p => p.Phone).HasMaxLength(24).IsOptional();
            Property(p => p.Fax).HasMaxLength(24).IsOptional();
            Property(p => p.HomePage).HasColumnType("ntext").IsOptional();

            HasMany(p => p.Products)
                .WithOptional(p => p.Suppliers)
                .HasForeignKey(p => p.SupplierID)
                .WillCascadeOnDelete(false);
        }
    }
}
