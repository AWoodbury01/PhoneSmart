using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneSmart.Data;
using PhoneSmart.Models;
using PhoneSmart.Models.PhoneViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneSmart.Controllers
{
    public class PhoneModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PhoneModelsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: PhoneModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhoneModel.ToListAsync());
        }

        //Compare
        public async Task<IActionResult> Compare()
        {

            List<PhoneModel> comparePhones = await _context.PhoneModel.ToListAsync();


            PhoneCompareViewModel vm = new PhoneCompareViewModel();

            vm.PhoneDropdownOne = new SelectList(_context.PhoneModel, "PhoneModelId", "Model");
            vm.PhoneDropdownTwo = new SelectList(_context.PhoneModel, "PhoneModelId", "Model");


            vm.PhoneOne = comparePhones[0];
            vm.PhoneTwo = comparePhones[4];

            return View(vm);
        }


        //Compare Dropdown One
        public async Task<IActionResult> CompareViewOne(int id)
        {
            List<PhoneModel> firstComparedPhone = await _context.PhoneModel
                .Where(p => p.PhoneModelId == id)
                .ToListAsync();

            return Ok(firstComparedPhone);
        }

        // GET: PhoneModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneModel = await _context.PhoneModel
                .FirstOrDefaultAsync(m => m.PhoneModelId == id);
            if (phoneModel == null)
            {
                return NotFound();
            }

            return View(phoneModel);
        }

        // GET: PhoneModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhoneModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhoneModelId,Manufacturer,Model,OS,Ram,DisplayType,DisplaySize,RefreshRate,Processor,MainCam,SecondaryCam,FrontCam,Battery,Security,isWirelessCharge,isWaterResist,PhoneURL")] PhoneModel phoneModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phoneModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phoneModel);
        }

        // GET: PhoneModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneModel = await _context.PhoneModel.FindAsync(id);
            if (phoneModel == null)
            {
                return NotFound();
            }
            return View(phoneModel);
        }

        // POST: PhoneModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhoneModelId,Manufacturer,Model,OS,Ram,DisplayType,DisplaySize,RefreshRate,Processor,MainCam,SecondaryCam,FrontCam,Battery,Security,isWirelessCharge,isWaterResist,PhoneURL")] PhoneModel phoneModel)
        {
            if (id != phoneModel.PhoneModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phoneModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneModelExists(phoneModel.PhoneModelId))
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
            return View(phoneModel);
        }

        // GET: PhoneModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phoneModel = await _context.PhoneModel
                .FirstOrDefaultAsync(m => m.PhoneModelId == id);
            if (phoneModel == null)
            {
                return NotFound();
            }

            return View(phoneModel);
        }

        // POST: PhoneModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phoneModel = await _context.PhoneModel.FindAsync(id);
            _context.PhoneModel.Remove(phoneModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhoneModelExists(int id)
        {
            return _context.PhoneModel.Any(e => e.PhoneModelId == id);
        }
    }
}
