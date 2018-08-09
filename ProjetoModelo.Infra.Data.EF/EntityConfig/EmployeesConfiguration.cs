using ProjetoModelo.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.EF.EntityConfig
{
    public class EmployeesConfiguration : EntityTypeConfiguration<Employees>
    {
        public EmployeesConfiguration()
        {
            HasKey(p => p.EmployeeID);
            Property(p => p.FirstName).HasColumnType("nvarchar") .HasMaxLength(10).IsRequired();
            Property(p => p.LastName).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            Property(p => p.Title).HasColumnType("nvarchar").HasMaxLength(30).IsOptional();
            Property(p => p.TitleOfCourtesy).HasColumnType("nvarchar").HasMaxLength(25).IsOptional();
            Property(p => p.BirthDate).HasColumnType("datetime").IsOptional();
            Property(p => p.HireDate).HasColumnType("datetime").IsOptional();
            Property(p => p.Address).HasColumnType("nvarchar").HasMaxLength(60).IsOptional();
            Property(p => p.City).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.Region).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.PostalCode).HasColumnType("nvarchar").HasMaxLength(10).IsOptional();
            Property(p => p.Country).HasColumnType("nvarchar").HasMaxLength(15).IsOptional();
            Property(p => p.HomePhone).HasColumnType("nvarchar").HasMaxLength(24).IsOptional();
            Property(p => p.Extension).HasColumnType("nvarchar").HasMaxLength(4).IsOptional();
            Property(p => p.Photo).HasColumnType("image").IsOptional();
            Property(p => p.Notes).HasColumnType("ntext").HasMaxLength(400).IsOptional();
            Property(p => p.ReportsTo).IsOptional();
            Property(p => p.PhotoPath).HasColumnType("nvarchar").HasMaxLength(255).IsOptional();

            HasMany(m => m.Orders)
                .WithRequired(m => m.Employees)
                .HasForeignKey(f => f.EmployeeID);

            HasMany(m => m.Employees1)
                .WithRequired(m => m.Employees2)
                .HasForeignKey(f => f.ReportsTo);

            HasMany(p => p.Territories)
              .WithMany(p => p.Employees)
              .Map(m =>
              {
                  m.ToTable("EmployeeTerritories");
                  m.MapLeftKey("EmployeeID");
                  m.MapRightKey("TerritoryID");
              });
        }
    }
}
