using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }//Pk

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string DepartmentName { get; set; }
        public int EmployeeID { get; set; }//Fk
        public  int SuperviserID  { get; set; }//Fk
    }
}
