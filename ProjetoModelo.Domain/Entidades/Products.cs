using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public partial class Products
    {
        public Products()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
        }

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

        public virtual Categories Categories { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}