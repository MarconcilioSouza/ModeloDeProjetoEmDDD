using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class OrdersViewModel
    {
        [Key]
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

        public virtual CustomersViewModel Customers { get; set; }
        public virtual EmployeesViewModel Employees { get; set; }
        public virtual ICollection<OrderDetailsViewModel> OrderDetails { get; set; }
        public virtual ShippersViewModel Shippers { get; set; }
    }
}