using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov
{
    class UserContext : DbContext
    {
        public UserContext() : base("UserDb14") { }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Corpus> Corpus { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<MatPlata> MatPlatas { get; set; }
        public DbSet<Proc> Procs  { get; set; }
        public DbSet<PowerSupply> PowerSupplies  { get; set; }
        public DbSet<RAM> RAMs  { get; set; }
        public DbSet<StorageDevice> StorageDevices  { get; set; }

        public DbSet<Zakaz> Zakazs { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Store> Stores { get; set; }

        public static implicit operator UserContext(Zakaz v)
        {
            throw new NotImplementedException();
        }
    }
}
