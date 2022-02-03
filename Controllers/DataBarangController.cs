using Inventory1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Controllers
{
    public class DataBarangController : Controller
    {
        private readonly AppDbContext _context;

        public DataBarangController(AppDbContext context)
        {
            _context = context;//_Context dimasukan konstruktor agar lebih ringkas
        }

        public IActionResult Tampil()
        {

            var SemuaBlog = _context.Tb_Barang.ToList();//sama saja dengan select * from tb_blog
            return View(SemuaBlog);

        }

        public IActionResult Create()//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DataBarang Parameter)//mnerima halaman yg akan diisi(inputan/proses)
        {

            //proses masukan ke database
            if (ModelState.IsValid)
            {
                _context.Add(Parameter);//mengganti dari insert into
                 await _context.SaveChangesAsync();// menyimpan perubahan

                return RedirectToAction("Tampil");
            }
            return View(Parameter);


        }
    }
}
