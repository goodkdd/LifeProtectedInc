using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class ServiceBudget
    {
        public int ServiceBudgetID { get; set; }//Pk
        

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public int Amount { get; set; }

        public int DepartmentID { get; set; }//FK


        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<Supervisor> Supervisors { get; set; }
    }
}
