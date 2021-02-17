using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacharSystem.Model
{
    class Dbcontext : DbContext
    {
        public Dbcontext() : base("name=cashier_m8_desktop") { }

        public DbSet<User> Users { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<Bills> Bills { get; set; }

    }
}
