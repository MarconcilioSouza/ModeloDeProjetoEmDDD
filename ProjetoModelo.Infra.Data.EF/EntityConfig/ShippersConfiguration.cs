using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{

    public class ShippersConfiguration : EntityTypeConfiguration<Shippers>
    {
        public ShippersConfiguration()
        {
            HasKey(p => p.ShipperID);
            Property(p => p.CompanyName).HasMaxLength(40).IsRequired();
            Property(p => p.Phone).HasMaxLength(25).IsOptional();

            HasMany(p => p.Orders)
                .WithRequired(p => p.Shippers)
                .HasForeignKey(p => p.ShipVia)
                .WillCascadeOnDelete(false);
        }
    }
}
