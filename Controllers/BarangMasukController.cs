using Inventory1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Controllers
{
    [Authorize]
    public class BarangMasukController : Controller
    {
        private readonly AppDbContext _context;
       
        public BarangMasukController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult TampilMasuk()
        {
            var SemuaBlog = _context.Tb_BarangMasuk.ToList();
                
                
            return View(SemuaBlog);
        }
        public IActionResult CreateMasuk()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMasuk(BarangMasukForm datanya )
        {
            string[] Id = _context.Tb_BarangMasuk.Select(x => x.Id_Masuk).ToArray();

            int temp;
            foreach (var item in Id)
            {
                temp = Int32.Parse(item.Split("-")[1]);
                datanya.Id_Masuk = "M00-" + (temp + 1);
            }

            if (datanya.Id_Masuk == null)
            {
                datanya.Id_Masuk = "M00-1";
            }
            if (ModelState.IsValid)
            {
                var get = new Db_BarangMasuk
                { 
                    Id_Masuk = datanya.Id_Masuk,
                    KodeBarang = datanya.KodeBarang,
                    NamaBarang = datanya.NamaBarang,
                    Jumlah = datanya.Jumlah,
                    status = datanya.status
                };

                _context.Add(get);
                await _context.SaveChangesAsync();

                return RedirectToAction("TampilMasuk");
            }

            return View();
        }
    }
}
