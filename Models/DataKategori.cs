using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class DataKategori
    {
        [Key]
        public string id_kategori { get; set; }
        [Required]
        public string Kategori { get; set; }
        
    }
}
