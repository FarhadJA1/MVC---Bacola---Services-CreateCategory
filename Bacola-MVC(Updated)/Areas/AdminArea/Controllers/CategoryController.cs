using Bacola_MVC_Updated_.Data;
using Bacola_MVC_Updated_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public IActionResult Detail(int id)
        {
            var category = _context.Categories.FirstOrDefault(m => m.Id == id);
            return Json(new
            {
                categoryName = category.Name,
                action = "Detail",
                Id = id
            });
        }
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.FirstOrDefault(m => m.Id == id);
            return Json(new
            {
                categoryName = category.Name,
                action = "Edit",
                Id = id
            });
        }
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(m => m.Id == id);
            return Json(new
            {
                categoryName = category.Name,
                action = "Delete",
                Id = id
            });
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categories category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = _context.Categories.Any(m => m.Name.Trim().ToLower() == category.Name.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "This category already exists");
                return View();
            }

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
