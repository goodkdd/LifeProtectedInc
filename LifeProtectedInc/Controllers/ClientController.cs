﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LifeProtectedInc.Data;
using LifeProtectedInc.Models;
using Microsoft.AspNetCore.Authorization;

namespace LifeProtectedInc.Controllers
{
    public class ClientController : Controller
    {
        private readonly LifeContext _context;
       
        public ClientController(LifeContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Client
        public async Task<IActionResult> Index()
        {
            var lifeContext = _context.Clients.Include(c => c.StaffMember).Include(c => c.Supervisor);
            return View(await lifeContext.ToListAsync());
        }
        [Authorize]
        // GET: Client/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.StaffMember)
                .Include(c => c.Supervisor)
                .SingleOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }
        [Authorize]
        // GET: Client/Create
        public IActionResult Create()
        {
            ViewData["StaffMemberID"] = new SelectList(_context.StaffMembers, "StaffMemberID", "Email");
            ViewData["SupervisorID"] = new SelectList(_context.Supervisors, "SupervisorID", "Email");
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientID,Name,Phone,Address,City,Province,PostalCode,Email,StaffMemberID,SupervisorID")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StaffMemberID"] = new SelectList(_context.StaffMembers, "StaffMemberID", "Email", client.StaffMemberID);
            ViewData["SupervisorID"] = new SelectList(_context.Supervisors, "SupervisorID", "Email", client.SupervisorID);
            return View(client);
        }
        [Authorize]
        // GET: Client/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.SingleOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }
            ViewData["StaffMemberID"] = new SelectList(_context.StaffMembers, "StaffMemberID", "Email", client.StaffMemberID);
            ViewData["SupervisorID"] = new SelectList(_context.Supervisors, "SupervisorID", "Email", client.SupervisorID);
            return View(client);
        }
        
        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientID,Name,Phone,Address,City,Province,PostalCode,Email,StaffMemberID,SupervisorID")] Client client)
        {
            if (id != client.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StaffMemberID"] = new SelectList(_context.StaffMembers, "StaffMemberID", "Email", client.StaffMemberID);
            ViewData["SupervisorID"] = new SelectList(_context.Supervisors, "SupervisorID", "Email", client.SupervisorID);
            return View(client);
        }
        [Authorize]
        // GET: Client/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.StaffMember)
                .Include(c => c.Supervisor)
                .SingleOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.SingleOrDefaultAsync(m => m.ClientID == id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.ClientID == id);
        }
    }
}
