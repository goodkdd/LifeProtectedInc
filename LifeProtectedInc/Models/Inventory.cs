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
        public int ProductNo { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ProductName { get; set; }



        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public int ProductAmount { get; set; }
    }
}
