using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public partial class Territories
    {
        public Territories()
        {
            this.Employees = new HashSet<Employees>();
        }

        public int TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}