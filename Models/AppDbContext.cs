using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public virtual DbSet<Roles> Tb_Roles { get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        public virtual DbSet<DataBarang> Tb_Barang { get; set; }
        public virtual DbSet<DataKategori> Tb_Kategori { get; set; }
        public virtual DbSet<BarangMasuk> Tb_Masuk { get; set; }
        public virtual DbSet<BarangKeluar> Tb_Keluar { get; set; }
    }
}
