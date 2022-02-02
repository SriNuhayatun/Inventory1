using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory1.Models
{
    public class Roles
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; }
    }
}
