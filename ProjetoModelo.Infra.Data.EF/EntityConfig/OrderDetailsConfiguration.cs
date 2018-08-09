

using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class OrderDetailsConfiguration : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsConfiguration()
        {
            HasKey(p => new { p.OrderID, p.ProductID });
            Property(p => p.UnitPrice).IsRequired();
            Property(p => p.Quantity).IsRequired();
            Property(p => p.Discount).IsRequired();
        }
    }
}
