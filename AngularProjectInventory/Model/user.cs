using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class user
    {
        public int userid { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime TDT { get; set; }
        public string userType { get; set; }
        public string userStatus { get; set; }
    }
}
