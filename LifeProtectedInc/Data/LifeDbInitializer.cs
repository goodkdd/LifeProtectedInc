﻿using LifeProtectedInc.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeProtectedInc.Data
{
    public class LifeDbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //1. Create the admin role
                var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync("admin"))
                {
                    //admin role does not exit - let's create it
                    IdentityResult IR = await roleManager.CreateAsync(new IdentityRole("admin"));
                }

                //2.  Create the admin user
                var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

                //Check if admin user already exists
                var user = await userManager.FindByEmailAsync("admin@LifeProtected.com");

                if (user == null)
                {
                    //The admin user represented by admin@identitydemo.com
                    //does not exist - create it

                    user = new ApplicationUser
                    {
                        UserName = "admin@LifeProtected.com",
                        Email = "admin@LifeProtected.com"

                    };
                    //Add it to the database
                    await userManager.CreateAsync(user, "Admin@123456");
                    //no lockout for the admin
                    await userManager.SetLockoutEnabledAsync(user, false);

                }//end if

                //3.  Add admin user to the admin role
                IdentityResult result = await userManager.AddToRoleAsync(user, "admin");


            }//end of using statement


        }//end of method
    }
}
