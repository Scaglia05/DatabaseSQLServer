using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImoveisApi.Models;

namespace ImoveisApi.Controllers
{
    public class VendedorImovelsController : Controller
    {
        private readonly Context _context;

        public VendedorImovelsController(Context context)
        {
            _context = context;
        }

        // GET: VendedorImovels
        public async Task<IActionResult> Index()
        {
            return View(await _context.VendedorImovel.ToListAsync());
        }

        // GET: VendedorImovels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedorImovel = await _context.VendedorImovel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendedorImovel == null)
            {
                return NotFound();
            }

            return View(vendedorImovel);
        }

        // GET: VendedorImovels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendedorImovels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] VendedorImovel vendedorImovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedorImovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendedorImovel);
        }

        // GET: VendedorImovels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedorImovel = await _context.VendedorImovel.FindAsync(id);
            if (vendedorImovel == null)
            {
                return NotFound();
            }
            return View(vendedorImovel);
        }

        // POST: VendedorImovels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] VendedorImovel vendedorImovel)
        {
            if (id != vendedorImovel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendedorImovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendedorImovelExists(vendedorImovel.Id))
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
            return View(vendedorImovel);
        }

        // GET: VendedorImovels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedorImovel = await _context.VendedorImovel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendedorImovel == null)
            {
                return NotFound();
            }

            return View(vendedorImovel);
        }

        // POST: VendedorImovels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendedorImovel = await _context.VendedorImovel.FindAsync(id);
            if (vendedorImovel != null)
            {
                _context.VendedorImovel.Remove(vendedorImovel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendedorImovelExists(int id)
        {
            return _context.VendedorImovel.Any(e => e.Id == id);
        }
    }
}
