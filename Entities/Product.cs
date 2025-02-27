using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilinecekApp.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
