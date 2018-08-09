using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class ProductsViewModel
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //public virtual CategoriesViewModel Categories { get; set; }
        public virtual ICollection<OrderDetailsViewModel> OrderDetails { get; set; }
        public virtual SuppliersViewModel Suppliers { get; set; }
    }
}