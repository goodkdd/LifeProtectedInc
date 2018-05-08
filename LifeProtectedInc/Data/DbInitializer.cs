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

            //===========================================Inventory==============================================//
            if (context.Inventories.Any())
            {
                return;
            }
            var inventory = new Inventory[]
      {
                new Inventory
                {
                    ProductNo=262,
                    ProductName="Hand Cuff",
                    ProductAmount=100

                },
                new Inventory
                {
                    ProductNo=965,
                    ProductName="AK-47",
                    ProductAmount=8000

                },
                new Inventory
                {
                    ProductNo=785,
                    ProductName="RPG",
                    ProductAmount=20000

                },
             


      };

            foreach (Inventory i in inventory)
            {
                context.Inventories.Add(i);
            }
            context.SaveChanges();

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
            foreach (StaffMember sm in staffmember)
            {
                context.StaffMembers.Add(sm);
            }
            context.SaveChanges();

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
            foreach (Supervisor s in supervisor)
            {
                context.Supervisors.Add(s);
            }
            context.SaveChanges();

            //===========================================Client=================================================//


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

            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }
            context.SaveChanges();





        }
    }
}
