using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class BarangMasuk
    {
        [Key]
        public string Id_Masuk { get; set; }
        [Required]
        public DataBarang KodeBarang { get; set; }
        [Required]
        public string NamaBarang { get; set; }
        [Required]
        public int Jumlah { get; set; }
        [Required]
        public string status { get; set; }
        
    }
}
