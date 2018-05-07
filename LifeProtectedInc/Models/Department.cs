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


        public int StaffMemberID { get; set; }//Fk
        public  int SupervisorID  { get; set; }//Fk

        public virtual ICollection<StaffMember> StaffMembers { get; set; }
        public virtual ICollection<Supervisor> Supervisors { get; set; }
        public virtual ICollection<ServiceBudget> ServiceBudgets { get; set; }
    }
}
