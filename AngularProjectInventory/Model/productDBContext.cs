using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class productDBContext: DbContext
    {
        public productDBContext(DbContextOptions<productDBContext> options): base(options)
        {

        }
        public DbSet<product> products { get; set; }
    }
}
