using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LifeProtectedInc.Data;
using LifeProtectedInc.Models;

namespace LifeProtectedInc.Controllers
{
    public class StaffMemberController : Controller
    {
        private readonly LifeContext _context;

        public StaffMemberController(LifeContext context)
        {
            _context = context;
        }

        // GET: StaffMember
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffMembers.ToListAsync());
        }

        // GET: StaffMember/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffMember = await _context.StaffMembers
                .SingleOrDefaultAsync(m => m.StaffMemberID == id);
            if (staffMember == null)
            {
                return NotFound();
            }

            return View(staffMember);
        }

        // GET: StaffMember/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StaffMember/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffMemberID,FirstName,LastName,Email,Phone")] StaffMember staffMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffMember);
        }

        // GET: StaffMember/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffMember = await _context.StaffMembers.SingleOrDefaultAsync(m => m.StaffMemberID == id);
            if (staffMember == null)
            {
                return NotFound();
            }
            return View(staffMember);
        }

        // POST: StaffMember/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffMemberID,FirstName,LastName,Email,Phone")] StaffMember staffMember)
        {
            if (id != staffMember.StaffMemberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffMemberExists(staffMember.StaffMemberID))
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
            return View(staffMember);
        }

        // GET: StaffMember/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffMember = await _context.StaffMembers
                .SingleOrDefaultAsync(m => m.StaffMemberID == id);
            if (staffMember == null)
            {
                return NotFound();
            }

            return View(staffMember);
        }

        // POST: StaffMember/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffMember = await _context.StaffMembers.SingleOrDefaultAsync(m => m.StaffMemberID == id);
            _context.StaffMembers.Remove(staffMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffMemberExists(int id)
        {
            return _context.StaffMembers.Any(e => e.StaffMemberID == id);
        }
    }
}
