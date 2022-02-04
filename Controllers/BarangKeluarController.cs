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
    public class BarangKeluarController : Controller
    {
        private readonly AppDbContext _context;

        public BarangKeluarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult TampilKeluar()
        {
            var SemuaBlog = _context.Tb_BarangKeluar.ToList();


            return View(SemuaBlog);
        }
        public IActionResult CreateKeluar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateKeluar(BarangKeluarForm datanya)
        {
            string[] Id = _context.Tb_BarangKeluar.Select(x => x.Id_Keluar).ToArray();

            int temp;
            foreach (var item in Id)
            {
                temp = Int32.Parse(item.Split("-")[1]);
                datanya.Id_Keluar = "M00-" + (temp + 1);
            }

            if (datanya.Id_Keluar == null)
            {
                datanya.Id_Keluar = "K00-1";
            }
            if (ModelState.IsValid)
            {
                var get = new Db_BarangKeluar
                {
                    Id_Keluar = datanya.Id_Keluar,
                    KodeBarang = datanya.KodeBarang,
                    NamaBarang = datanya.NamaBarang,
                    Jumlah = datanya.Jumlah,
                    status = datanya.status
                };

                _context.Add(get);
                await _context.SaveChangesAsync();

                return RedirectToAction("TampilKeluar");
            }

            return View();
        }
    }
}
