using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furndaqaaqas.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public bool IsNew { get; set; }
        public string PhotoUrl1 { get; set; }
        public string PhotoUrl2 { get; set; }
    }
}
