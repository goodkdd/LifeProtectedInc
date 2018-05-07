using LifeProtectedInc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Data
{
    public class LifeContext : DbContext
    {

        //eudghy: Constructor
        public LifeContext(DbContextOptions<LifeContext> options) : base(options)
        {

        }

        //Entity Sets
        public DbSet<Client> Clients { get; set; }
        public DbSet<StaffMember> StaffMembers { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<ServiceBudget> ServiceBudgets { get; set; }
        public DbSet<ServiceBudget> Departments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }


   //helo
    }
}