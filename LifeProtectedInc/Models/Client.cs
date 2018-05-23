using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Models
{
    public class Client
    {
        public int ClientID { get; set; }//Pk

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        [Column(TypeName = "nchar(2)")]
        public string Province { get; set; }

        [Display(Name = "Postal Code")]
        [Required]
        [StringLength(7)]
        [Column(TypeName = "nchar(7)")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Consultant")]
        public int StaffMemberID { get; set; }//Fk
        public int SupervisorID { get; set; }//Fk


        [Display(Name = "Consultant")]
        public virtual StaffMember StaffMember { get; set; }
        public virtual Supervisor Supervisor { get; set; }

    }
}
