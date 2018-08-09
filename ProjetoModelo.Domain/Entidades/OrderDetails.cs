using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public class OrderDetails
    {
        public OrderDetails()
        {
            this.Orders = new Orders();
            this.Products = new Products();
        }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public Orders Orders { get; set; }
        public Products Products { get; set; }
    }
}
