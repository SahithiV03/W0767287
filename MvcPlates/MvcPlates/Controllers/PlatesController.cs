using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlates.Data;
using MvcPlates.Models;

namespace MvcPlates.Controllers
{
    public class PlatesController : Controller
    {

        // GET: Plates
        public IActionResult Index()
        {
            return View(SeedData.Plates);
        }

        // GET: Plates/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plate = SeedData.Plates.FirstOrDefault(m => m.Id == id);
            if (plate == null)
            {
                return NotFound();
            }

            return View(plate);
        }

        // GET: Plates/Create
        public IActionResult Create()
        {
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Brand = new List<SelectListItem>
            {
                new SelectListItem {Text = "Selki", Value = "Selki"},
                new SelectListItem {Text = "Delim", Value = "Delim"},
                new SelectListItem {Text = "Valko", Value = "Valko"},
                new SelectListItem {Text = "Zelon", Value = "Zelon"}
            };
            return View();
        }

        // POST: Plates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Brand,Color,Size,Cost,Rating")] Plate plate)
        {
            plate.Id = Guid.NewGuid().ToString();
            plate.CreatedDate = DateTime.Now;
            plate.ModifiedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                SeedData.Plates.Add(plate);
                return RedirectToAction(nameof(Index));
            }
            return View(plate);
        }

        // GET: Plates/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var plate = SeedData.Plates.FirstOrDefault(m => m.Id == id);
            if (plate == null)
            {
                return NotFound();
            }
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Brand = new List<SelectListItem>
            {
                new SelectListItem {Text = "Selki", Value = "Selki"},
                new SelectListItem {Text = "Delim", Value = "Delim"},
                new SelectListItem {Text = "Valko", Value = "Valko"},
                new SelectListItem {Text = "Zelon", Value = "Zelon"}
            };
            return View(plate);
        }

        // POST: Plates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, [Bind("Id,Brand,Color,Size,Cost,Rating,CreatedDate")] Plate plate)
        {
            plate.ModifiedDate = DateTime.Now;
            if (id != plate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var updatedPlate = SeedData.Plates
                        .FirstOrDefault(m => m.Id == id);
                    updatedPlate.Size = plate.Size;
                    updatedPlate.Rating = plate.Rating;
                    updatedPlate.Cost = plate.Cost;
                    updatedPlate.Brand = plate.Brand;
                    updatedPlate.Color = plate.Color;
                    updatedPlate.ModifiedDate = plate.ModifiedDate;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlateExists(plate.Id))
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
            return View(plate);
        }

        // GET: Plates/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plate = SeedData.Plates.FirstOrDefault(m => m.Id == id);
            if (plate == null)
            {
                return NotFound();
            }

            return View(plate);
        }

        // POST: Plates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var plate = SeedData.Plates
               .FirstOrDefault(m => m.Id == id);
            if (plate != null)
                SeedData.Plates.Remove(plate);
            return RedirectToAction(nameof(Index));
        }

        private bool PlateExists(string id)
        {
            return SeedData.Plates.Any(e => e.Id == id);
        }
    }
}
