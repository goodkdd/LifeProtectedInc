using System;
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
    
    public class SupervisorController : Controller
    {
        private readonly LifeContext _context;

        public SupervisorController(LifeContext context)
        {
            _context = context;
        }

        // GET: Supervisor
        public async Task<IActionResult> Index()
        {
            var lifeContext = _context.Supervisors.Include(s => s.Inventory);
            return View(await lifeContext.ToListAsync());
        }

        // GET: Supervisor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supervisor = await _context.Supervisors
                .Include(s => s.Inventory)
                .SingleOrDefaultAsync(m => m.SupervisorID == id);
            if (supervisor == null)
            {
                return NotFound();
            }

            return View(supervisor);
        }

        // GET: Supervisor/Create
        public IActionResult Create()
        {
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "ProductName");
            return View();
        }

        // POST: Supervisor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupervisorID,FirstName,LastName,Email,Phone,InventoryID")] Supervisor supervisor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supervisor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "ProductName", supervisor.InventoryID);
            return View(supervisor);
        }

        // GET: Supervisor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supervisor = await _context.Supervisors.SingleOrDefaultAsync(m => m.SupervisorID == id);
            if (supervisor == null)
            {
                return NotFound();
            }
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "ProductName", supervisor.InventoryID);
            return View(supervisor);
        }

        // POST: Supervisor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupervisorID,FirstName,LastName,Email,Phone,InventoryID")] Supervisor supervisor)
        {
            if (id != supervisor.SupervisorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supervisor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupervisorExists(supervisor.SupervisorID))
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
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "ProductName", supervisor.InventoryID);
            return View(supervisor);
        }

        // GET: Supervisor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supervisor = await _context.Supervisors
                .Include(s => s.Inventory)
                .SingleOrDefaultAsync(m => m.SupervisorID == id);
            if (supervisor == null)
            {
                return NotFound();
            }

            return View(supervisor);
        }

        // POST: Supervisor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supervisor = await _context.Supervisors.SingleOrDefaultAsync(m => m.SupervisorID == id);
            _context.Supervisors.Remove(supervisor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupervisorExists(int id)
        {
            return _context.Supervisors.Any(e => e.SupervisorID == id);
        }
    }
}
