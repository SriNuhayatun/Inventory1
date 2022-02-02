using Inventory1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Controllers
{
    public class DataKategoriController : Controller
    {
        private readonly AppDbContext _context;

        public DataKategoriController(AppDbContext context)
        {
            _context = context;//_Context dimasukan konstruktor agar lebih ringkas
        }

        public IActionResult TampilKategori()
        {

            var SemuaBlog = _context.Tb_Kategori.ToList();//sama saja dengan select * from tb_blog
            return View(SemuaBlog);

        }
        
        public IActionResult CreateKategori()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DataKategori Parameter)//mnerima halaman yg akan diisi(inputan/proses)
        {

            //proses masukan ke database
            if (ModelState.IsValid)
            {
                _context.Add(Parameter);//mengganti dari insert into
                await _context.SaveChangesAsync();// menyimpan perubahan

                return RedirectToAction("TampilKategori");
            }
            return View(Parameter);


        }
    }
}
