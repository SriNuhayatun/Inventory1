using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class Db_BarangKeluar
    {
        [Key]
        public string Id_Keluar { get; set; }
        
        public String KodeBarang { get; set; }
     
        public string NamaBarang { get; set; }
        
        public int Jumlah { get; set; }
        
        public string status { get; set; }

        [ForeignKey("KodeBarang")]
        public Db_DataBarang KodeBrg { get; set; }
    }
}
