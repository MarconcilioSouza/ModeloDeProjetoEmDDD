using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entidades
{
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            this.Customers = new HashSet<Customers>();
        }

        public int CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
    }
}