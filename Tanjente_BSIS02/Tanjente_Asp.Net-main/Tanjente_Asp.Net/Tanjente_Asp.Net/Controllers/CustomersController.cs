using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tanjente_Asp.Net.Data;
using Tanjente_Asp.Net.Models;

namespace Tanjente_Asp.Net.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/id
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return NotFound();

            return View(customer);
        }

        // POST: Customers/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string originalCustomerName, Customer customer)
        {
            if (originalCustomerName != customer.CustomerName)
            {
                var existingCustomer = await _context.Customers.FindAsync(originalCustomerName);
                if (existingCustomer == null) return NotFound();

                _context.Customers.Remove(existingCustomer);
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerName)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/id
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();

            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerName == id);
            if (customer == null) return NotFound();

            return View(customer);
        }

        // POST: Customers/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(string id)
        {
            return _context.Customers.Any(e => e.CustomerName == id);
        }
    }
}