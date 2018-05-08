using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class Supervisor
    {
        public int SupervisorID { get; set; }//Pk

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


    
        public int InventoryID { get; set; }//Fk
       


      
        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        
    }
}
