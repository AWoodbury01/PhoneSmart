using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneSmart.Data;
using PhoneSmart.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneSmart.Controllers
{
    public class PhonesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PhonesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Phones
        public async Task<IActionResult> Index(string searchString)
        {
            //Search function
            ViewData["CurrentFilter"] = searchString;

            var applicationDbContext = _context.Phone
            .Include(p => p.PhoneModel)
            .Include(p => p.User)
            .AsQueryable();


            if (!String.IsNullOrEmpty(searchString))
            {
                applicationDbContext = applicationDbContext
                    .Where(p => p.PhoneModel.Manufacturer.Contains(searchString)
                    ||
                    p.PhoneModel.Model.Contains(searchString));
            }
            if (applicationDbContext.Count() < 1)
            {

                return View("SearchError");
            }

            return View(await applicationDbContext.ToListAsync());
            //return View(await _context.Phone.ToListAsync());
        }

        // GET: Phones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .Include(p => p.PhoneModel)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PhoneId == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }


        // GET: Phones/Create
        public IActionResult Create()
        {
            ViewData["PhoneModelId"] = new SelectList(_context.PhoneModel, "PhoneModelId", "Model");
            return View();
        }

        // POST: Phones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhoneId,UserId,Color,Storage,Condition,PhoneModelId,Price")] Phone phone)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                phone.UserId = user.Id;
                _context.Add(phone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhoneModelId"] = new SelectList(_context.PhoneModel, "PhoneModelId", "Model", phone.PhoneModelId);
            return View(phone);
        }

        // GET: Phones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone.FindAsync(id);
            if (phone == null)
            {
                return NotFound();
            }
            return View(phone);
        }

        // POST: Phones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhoneId,UserId,Color,Storage,Condition,PhoneModelId,Price")] Phone phone)
        {
            if (id != phone.PhoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneExists(phone.PhoneId))
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
            return View(phone);
        }

        // GET: Phones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .Include(p => p.PhoneModel)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PhoneId == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // POST: Phones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phone = await _context.Phone.FindAsync(id);
            _context.Phone.Remove(phone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhoneExists(int id)
        {
            return _context.Phone.Any(e => e.PhoneId == id);
        }
    }
}
