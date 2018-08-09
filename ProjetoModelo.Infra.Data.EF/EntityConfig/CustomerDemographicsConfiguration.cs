using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    class CustomerDemographicsConfiguration : EntityTypeConfiguration<CustomerDemographics>
    {
        public CustomerDemographicsConfiguration()
        {
            HasKey(p => p.CustomerTypeID);
            Property(p => p.CustomerDesc).HasColumnType("ntext").IsOptional();

            ToTable("CustomerDemographics");

            HasMany(p => p.Customers)
               .WithMany(p => p.CustomerDemographics)
               .Map(m =>
               {
                   m.ToTable("CustomerCustomerDemo");
                   m.MapLeftKey("CustomerTypeID");
                   m.MapRightKey("CustomerID");
               });
        }
    }
}
