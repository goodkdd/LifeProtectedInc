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

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        public int ServiceBudgetID  { get; set; }//Fk
        public int InventoryID { get; set; }//Fk
       


        public virtual ServiceBudget ServiceBudget { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
