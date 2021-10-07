using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class product
    {
        public int id { get; set; }
        public string productid { get; set; }
        public string productName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string productImage { get; set; }
        public string userid { get; set; }
        public int stocks { get; set; }
        public DateTime TDT { get; set; }
        public DateTime UDT { get; set; }
    }
}
