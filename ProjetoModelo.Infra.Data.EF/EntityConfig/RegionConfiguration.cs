
using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            HasKey(p => p.RegionID);
            Property(p => p.RegionDescription).HasMaxLength(50).IsRequired();

            HasMany(p => p.Territories)
                .WithRequired(p => p.Region)
                .HasForeignKey(p => p.RegionID)
                .WillCascadeOnDelete(false);
        }
    }
}
