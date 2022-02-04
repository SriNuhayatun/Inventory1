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
        public async Task<IActionResult> Create(DataBarangForm Parameter)
        {
            string[] Id = _context.Tb_Barang.Select(x => x.KodeBarang).ToArray();

            int temp;
            foreach (var item in Id)
            {
                temp = Int32.Parse(item.Split("-")[1]);
                Parameter.KodeBarang = "B00-" + (temp + 1);
            }

            if (Parameter.KodeBarang == null)
            {
                Parameter.KodeBarang = "B00-1";
            }

            var get = new Db_DataBarang
            {

                KodeBarang = Parameter.KodeBarang,
                Kategori = Parameter.Kategori,
                NamaBarang = Parameter.NamaBarang,
                status = Parameter.status,
                Stok = Parameter.Stok
            };

            if (ModelState.IsValid)
            {
              
                _context.Add(get);
                 await _context.SaveChangesAsync();

                return RedirectToAction("Tampil");
            }
            return View(Parameter);
        }
    }
}
