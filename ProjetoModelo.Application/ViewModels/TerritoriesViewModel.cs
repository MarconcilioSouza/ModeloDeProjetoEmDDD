
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class TerritoriesViewModel
    {
        [Key]
        public int TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual RegionViewModel Region { get; set; }
        public virtual ICollection<EmployeesViewModel> Employees { get; set; }
    }
}