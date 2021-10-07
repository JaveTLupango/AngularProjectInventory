using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class OrderDetailsDBContext: DbContext
    {
        public OrderDetailsDBContext(DbContextOptions<OrderDetailsDBContext> options): base(options)
        {

        }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
