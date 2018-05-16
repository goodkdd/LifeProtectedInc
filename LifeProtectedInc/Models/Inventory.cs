using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }//Pk
        [Display(Name = "Product No")]
        public int ProductNo { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Product Amount")]
        public decimal ProductAmount { get; set; }



        public virtual ICollection<Supervisor> Supervisors { get; set; }
    }
}
