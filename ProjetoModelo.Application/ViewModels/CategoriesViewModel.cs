using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class CategoriesViewModel
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Prencha o campo Nome")]
        [MaxLength(15,ErrorMessage ="Máximo {0} caracteres")]
        public string CategoryName { get; set; }
        [MaxLength(400, ErrorMessage = "Máximo {0} caracteres")]
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<ProductsViewModel> Products { get; set; }
    }
}