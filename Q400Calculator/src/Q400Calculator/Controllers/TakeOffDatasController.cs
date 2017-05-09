using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class TakeOffDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TakeOffDatasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TakeOffDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakeOffData.ToListAsync());
        }

        // GET: TakeOffDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeOffData = await _context.TakeOffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeOffData == null)
            {
                return NotFound();
            }

            return View(takeOffData);
        }

        // GET: TakeOffDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TakeOffDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OAT,above20,altitude,flaps,v2,vr,weight")] TakeOffData takeOffData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takeOffData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(takeOffData);
        }

        // GET: TakeOffDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeOffData = await _context.TakeOffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeOffData == null)
            {
                return NotFound();
            }
            return View(takeOffData);
        }

        // POST: TakeOffDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OAT,above20,altitude,flaps,v2,vr,weight")] TakeOffData takeOffData)
        {
            if (id != takeOffData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takeOffData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakeOffDataExists(takeOffData.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(takeOffData);
        }

        // GET: TakeOffDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeOffData = await _context.TakeOffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeOffData == null)
            {
                return NotFound();
            }

            return View(takeOffData);
        }

        // POST: TakeOffDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takeOffData = await _context.TakeOffData.SingleOrDefaultAsync(m => m.Id == id);
            _context.TakeOffData.Remove(takeOffData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TakeOffDataExists(int id)
        {
            return _context.TakeOffData.Any(e => e.Id == id);
        }
    }
}
