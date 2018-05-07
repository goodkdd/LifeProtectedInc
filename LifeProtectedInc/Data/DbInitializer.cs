using LifeProtectedInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Data
{
    public class DbInitializer
    {
        public static void Initialize(LifeContext context)
        {
            //===========================================Client=================================================//
            if (context.Clients.Any())
            {
                return;   
            }

            var clients = new Client[]
            {
                new Client
                {
                    Name ="Dywane Johnson",
                    Phone ="506-555-6598",
                    Address = "46 drive avenue",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode="E1C 0K6",
                    Email ="TheRock@awsome.com"                  
                },

                 new Client
                {
                    Name ="Will Smith",
                    Phone ="506-555-3325",
                    Address = "506 killer drive",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode="E1C 0K6",
                    Email ="WilltheKill@dead.com"
                }

            };
            //===========================================StaffMember============================================//
            var staffmember = new StaffMember[]
            {
                new StaffMember
                {
                    FirstName ="Eudghy",
                    LastName ="Delcy",
                    Email ="Eudghy@LifeProtectdInc.com",
                    Phone ="506-999-6969"
                },
                 new StaffMember
                {
                    FirstName ="Quiton",
                    LastName ="Savoie",
                    Email ="Quinton@LifeProtectdInc.com",
                    Phone ="506-999-6969"
                }

            };

            //===========================================Supervisor=============================================//
            var supervisor = new Supervisor[]
            {
                new Supervisor
                {
                    FirstName ="Patrick",
                    LastName ="Martin",
                    Email ="Patrick@LifeProtectdInc.com",
                    Phone ="506-740-0631"
                },
                 new Supervisor
                {
                    FirstName ="Marc",
                    LastName ="Williams",
                    Email ="Marc@LifeProtectdInc.com",
                    Phone ="506-123-456"
                }

            };

            //===========================================Department=============================================//
            var department = new Department[]
          {
                new Department
                {
                    DepartmentName ="TransportSecurity"
                    
                },
                 new Department
                {
                    DepartmentName ="GuardHouse"
                    
                },
                 new Department
                {
                    DepartmentName ="PrivateSecurity"

                },
                 new Department
                {
                    DepartmentName ="DefenseTraining"

                },
                 new Department
                {
                    DepartmentName ="DataProtection"

                }
              

          };

            //===========================================ServiceBudget==========================================//
            var servicebudget = new ServiceBudget[]
         {
                new ServiceBudget
                {
                   Amount= 300000

                },
                 new ServiceBudget
                {
                   Amount= 200000

                },
                  new ServiceBudget
                {
                   Amount= 800000

                },
                   new ServiceBudget
                {
                   Amount= 400000

                },
                    new ServiceBudget
                {
                   Amount= 900000

                }


         };

            //===========================================Inventory==============================================//
            var inventory = new Inventory[]
      {
                new Inventory
                {
                    ProductNo=26206

                },
                new Inventory
                {
                    ProductNo=96565

                },
                new Inventory
                {
                    ProductNo=78555

                },
                new Inventory
                {
                    ProductNo=2622206

                },
                new Inventory
                {
                    ProductNo=985548

                },
                new Inventory
                {
                    ProductNo=267666206

                },
                new Inventory
                {
                    ProductNo=767678

                }


      };
        }
    }
}
