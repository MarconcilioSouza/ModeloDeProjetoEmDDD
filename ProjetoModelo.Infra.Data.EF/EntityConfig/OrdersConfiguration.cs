using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class OrdersConfiguration : EntityTypeConfiguration<Orders>
    {
        public OrdersConfiguration()
        {
            HasKey(p => p.OrderID);
            Property(p => p.OrderDate).HasColumnType("datetime").IsOptional();
            Property(p => p.RequiredDate).HasColumnType("datetime").IsOptional();
            Property(p => p.ShippedDate).HasColumnType("datetime").IsOptional();
            Property(p => p.Freight).IsOptional();
            Property(p => p.ShipName).HasMaxLength(40).IsOptional();
            Property(p => p.ShipAddress).HasMaxLength(60).IsOptional();
            Property(p => p.ShipCity).HasMaxLength(15).IsOptional();
            Property(p => p.ShipRegion).HasMaxLength(15).IsOptional();
            Property(p => p.ShipPostalCode).HasMaxLength(10).IsOptional();
            Property(p => p.ShipCountry).HasMaxLength(15).IsOptional();

            ToTable("Orders");

            HasMany(p => p.OrderDetails)
                .WithRequired(p => p.Orders)
                .HasForeignKey(p => p.OrderID);
        }
    }
}
