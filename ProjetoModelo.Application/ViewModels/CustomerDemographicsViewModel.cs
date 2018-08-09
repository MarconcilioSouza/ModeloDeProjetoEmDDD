
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class CustomerDemographicsViewModel
    {
        [Key]
        public int CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<CustomersViewModel> Customers { get; set; }
    }
}