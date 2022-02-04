using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class DataBarangForm
    {
        public string KodeBarang { get; set; }

        public string Kategori { get; set; }

        public string NamaBarang { get; set; }

        public string status { get; set; }

        public int Stok { get; set; }
    }
}
