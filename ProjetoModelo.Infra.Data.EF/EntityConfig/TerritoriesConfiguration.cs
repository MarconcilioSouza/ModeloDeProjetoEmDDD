
using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{

    public class TerritoriesConfiguration : EntityTypeConfiguration<Territories>
    {
        public TerritoriesConfiguration()
        {
            HasKey(p => p.TerritoryID);
            Property(p => p.TerritoryDescription).HasMaxLength(50).IsRequired();
        }
    }
}
