using Inventory1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Controllers
{
    public class BarangKeluarController : Controller
    {
        private readonly AppDbContext _context;

        public BarangKeluarController(AppDbContext context)
        {
            _context = context;//_Context dimasukan konstruktor agar lebih ringkas
        }
        public IActionResult TampilKeluar()
        {
            var SemuaBlog = _context.Tb_BarangKeluar.ToList();


            return View(SemuaBlog);
        }
        public IActionResult CreateKeluar()//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateKeluar(BarangKeluarForm datanya)//mnerima halaman yg akan diisi(inputan/proses)
        {
            //proses masukan ke database
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

                _context.Add(get);//mengganti dari insert into
                await _context.SaveChangesAsync();// menyimpan perubahan

                return RedirectToAction("TampilKeluar");
            }

            return View();
        }
    }
}
