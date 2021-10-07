using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectInventory.Model
{
    public class usersDBContext: DbContext
    {
        public usersDBContext(DbContextOptions<usersDBContext> options) : base(options)
        {

        }
        public DbSet<user> users { get; set; }
    }
}
