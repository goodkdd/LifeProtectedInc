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
      //      if (context.Inventories.Any())
      //      {
      //          return;
      //      }
      //      var inventory = new Inventory[]
      //{
      //          new Inventory
      //          {
      //              ProductNo=262,
      //              ProductName="Hand Cuff",
      //              ProductAmount=100

      //          },
      //          new Inventory
      //          {
      //              ProductNo=965,
      //              ProductName="AK-47",
      //              ProductAmount=8000

      //          },
      //          new Inventory
      //          {
      //              ProductNo=785,
      //              ProductName="RPG",
      //              ProductAmount=20000

      //          },

      //            new Inventory
      //          {
      //              ProductNo=633,
      //              ProductName="Body Armor",
      //              ProductAmount=7000

      //          },
      //          new Inventory
      //          {
      //              ProductNo=625,
      //              ProductName="Black Combat Boots",
      //              ProductAmount=300

      //          },
      //          new Inventory
      //          {
      //              ProductNo=899,
      //              ProductName="Tactical Black Gloves",
      //              ProductAmount=75

      //          },

      //            new Inventory
      //          {
      //              ProductNo=001,
      //              ProductName="Shooting Glasses",
      //              ProductAmount=200

      //          },
      //          new Inventory
      //          {
      //              ProductNo=660,
      //              ProductName="Ear Piece",
      //              ProductAmount=75

      //          },
      //          new Inventory
      //          {
      //              ProductNo=784,
      //              ProductName="Karambit",
      //              ProductAmount=150

      //          },

      //            new Inventory
      //          {
      //              ProductNo=006,
      //              ProductName="SOG Seal Knife 2000",
      //              ProductAmount=250

      //          },
      //          new Inventory
      //          {
      //              ProductNo=452,
      //              ProductName="Black Light",
      //              ProductAmount=60

      //          },
      //          new Inventory
      //          {
      //              ProductNo=0487,
      //              ProductName="Mag Pouches",
      //              ProductAmount=80

      //          },

      //          new Inventory
      //          {
      //              ProductNo=483,
      //              ProductName="Laser Dot",
      //              ProductAmount=110

      //          },
      //          new Inventory
      //          {
      //              ProductNo=6661,
      //              ProductName="Taser",
      //              ProductAmount=40

      //          },
      //          new Inventory
      //          {
      //              ProductNo=1205,
      //              ProductName="Walkie Talkie",
      //              ProductAmount=80

      //          }



      //};

      //      foreach (Inventory i in inventory)
      //      {
      //          context.Inventories.Add(i);
      //      }
      //      context.SaveChanges();

      //      //===========================================StaffMember============================================//

      //      var staffmember = new StaffMember[]
      //      {
      //          new StaffMember
      //          {
      //              FirstName ="John",
      //              LastName ="Switch",
      //              Email ="John@LifeProtectdInc.com",
      //              Phone ="506-999-6969"
      //          },
      //           new StaffMember
      //          {
      //              FirstName ="Sam",
      //              LastName ="Quimpere",
      //              Email ="Sam@LifeProtectdInc.com",
      //              Phone ="506-999-6969"
      //          },
      //          new StaffMember
      //          {
      //              FirstName ="Elsa",
      //              LastName ="Ice",
      //              Email ="Elsa@LifeProtectdInc.com",
      //              Phone ="506-999-0206"
      //          },
      //           new StaffMember
      //          {
      //              FirstName ="Amy",
      //              LastName ="Owen",
      //              Email ="Amy@LifeProtectdInc.com",
      //              Phone ="506-662-9853"
      //          },

      //           new StaffMember
      //          {
      //              FirstName ="Eric",
      //              LastName ="Bellfleur",
      //              Email ="Eric@LifeProtectdInc.com",
      //              Phone ="506-185-3269"
      //          },
      //           new StaffMember
      //          {
      //              FirstName ="Emily",
      //              LastName ="Dufour",
      //              Email ="Emily@LifeProtectdInc.com",
      //              Phone ="506-652-0655"
      //          },

      //               new StaffMember
      //          {
      //              FirstName ="Dean",
      //              LastName ="Winchester",
      //              Email ="Dean@LifeProtectdInc.com",
      //              Phone ="506-055-0550"
      //          },
      //           new StaffMember
      //          {
      //              FirstName ="Steve",
      //              LastName ="Larousse",
      //              Email ="Steve@LifeProtectdInc.com",
      //              Phone ="506-653-9688"
      //          }


      //      };
      //      foreach (StaffMember sm in staffmember)
      //      {
      //          context.StaffMembers.Add(sm);
      //      }
      //      context.SaveChanges();

            //===========================================Supervisor=============================================//
            var supervisor = new Supervisor[]
            {
                new Supervisor
                {
                    FirstName ="Patrick",
                    LastName ="Martin",
                    Email ="Patrick@LifeProtectdInc.com",
                    Phone ="506-740-0631",
                    InventoryID =4
                },
                 new Supervisor
                {
                    FirstName ="Marc",
                    LastName ="Williams",
                    Email ="Marc@LifeProtectdInc.com",
                    Phone ="506-123-4656",
                    InventoryID =5
                },

                 new Supervisor
                {
                    FirstName ="Quinton",
                    LastName ="Savoie",
                    Email ="Quinton@LifeProtectdInc.com",
                    Phone ="506-975-3333",
                    InventoryID =6
                },
                 new Supervisor
                {
                    FirstName ="Eughy",
                    LastName ="Delscy",
                    Email ="Eughy@LifeProtectdInc.com",
                    Phone ="506-895-6985",
                    InventoryID =7
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
                    Email ="TheRock@awsome.com",
                    StaffMemberID=3,
                    SupervisorID=4
                },

                 new Client
                {
                    Name ="Will Smith",
                    Phone ="506-555-3325",
                    Address = "506 killer drive",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode="E1C 0K6",
                    Email ="WilltheKill@dead.com",
                    StaffMemberID=4,
                    SupervisorID=5
                },

                    new Client
                {
                    Name ="Dovico",
                    Phone ="506-066-8888",
                    Address = "406 drive avenue",
                    City = "Dieppe",
                    Province = "NB",
                    PostalCode="E1C 0P6",
                    Email ="Dovico@Dovico.com",
                    StaffMemberID=5,
                    SupervisorID=6
                },

                 new Client
                {
                    Name ="RCMP",
                    Phone ="506-905-6395",
                    Address = "590 main drive",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode="E1C 9Y8",
                    Email ="RCMP@Law.com",
                    StaffMemberID=7,
                    SupervisorID=8
                },

                 new Client
                {
                    Name ="Lester Inc",
                    Phone ="506-562-3662",
                    Address = "999 champlain",
                    City = "Dieppe",
                    Province = "NB",
                    PostalCode="E1C 0P6",
                    Email ="LesterInc@Lester Inc.com",
                    StaffMemberID=8,
                    SupervisorID=9
                },

                 new Client
                {
                    Name ="FireDept",
                    Phone ="506-706-0256",
                    Address = "65 Back Street",
                    City = "Riverview",
                    Province = "NB",
                    PostalCode="E1C 9Y8",
                    Email ="FireDept@Fire.com",
                    StaffMemberID=10,
                    SupervisorID=10
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
