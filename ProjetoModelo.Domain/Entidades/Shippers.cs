using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public partial class Shippers
    {
        public Shippers()
        {
            this.Orders = new HashSet<Orders>();
        }

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}