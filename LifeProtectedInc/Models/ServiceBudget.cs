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
        public int DepartmentID { get; set; }//FK

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public int Amount { get; set; }
    }
}
