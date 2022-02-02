using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class DataBarang
    {
        [Key]
        public string KodeBarang { get; set; }
        [Required]
        public string Kategori { get; set; }
        [Required]
        public string NamaBarang { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public int Stok { get; set; }
        
    }
}
