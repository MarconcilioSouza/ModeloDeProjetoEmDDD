using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class CustomersConfiguration : EntityTypeConfiguration<Customers>
    {
        public CustomersConfiguration()
        {
            HasKey(p => p.CustomerID);
            Property(p => p.CompanyName).HasColumnType("nvarchar").HasMaxLength(40).IsRequired();
            Property(p => p.ContactName).HasColumnType("nvarchar").HasMaxLength(30).IsOptional();
            Property(p => p.ContactTitle).HasColumnType("nvarchar").HasMaxLength(30).IsOptional();
            Property(p => p.Address).HasColumnType("nvarchar").HasMaxLength(60).IsOptional();
            Property(p => p.City).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.Region).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.PostalCode).HasColumnType("nvarchar").HasMaxLength(10).IsOptional();
            Property(p => p.Country).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.Phone).HasColumnType("nvarchar").HasMaxLength(24).IsOptional();
            Property(p => p.Fax).HasColumnType("nvarchar").HasMaxLength(24).IsOptional();

            ToTable("Customers");

            HasMany(p => p.Orders)
                .WithRequired(p => p.Customers)
                .HasForeignKey(p => p.CustomerID);
        }
    }
}
