using Inventory1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Controllers
{
    [Authorize]
    public class DataBarangController : Controller
    {
        private readonly AppDbContext _context;

        public DataBarangController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Tampil()
        {

            var SemuaBlog = _context.Tb_Barang.ToList();
            return View(SemuaBlog);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DataBarang Parameter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Parameter);
                 await _context.SaveChangesAsync();

                return RedirectToAction("Tampil");
            }
            return View(Parameter);


        }
    }
}
