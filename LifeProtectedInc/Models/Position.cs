using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class Position
    {
        public int PositionID { get; set; }//Pk
        public int EmployeeID { get; set; }//Fk
        public int SuperviserID { get; set; }//Fk

    }
}
