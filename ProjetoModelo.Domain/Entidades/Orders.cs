using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public partial class Orders
    {
        public Orders()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
            this.Employees = new Employees();
            this.Customers = new Customers();
            this.Shippers = new Shippers();
        }

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Shippers Shippers { get; set; }
    }
}