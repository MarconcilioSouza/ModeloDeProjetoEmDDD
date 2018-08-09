using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class OrderDetailsViewModel
    {
        [Key]
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public OrdersViewModel Orders { get; set; }
        public ProductsViewModel Products { get; set; }
    }
}