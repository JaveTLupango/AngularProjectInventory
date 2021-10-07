using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class OrderDetail
    {
        public int id { get; set; }
        public string Orderid { get; set; }
        public string ProductID { get; set; }
        public int QTY { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TDT { get; set; }
        public DateTime UDT { get; set; }
    }
}
