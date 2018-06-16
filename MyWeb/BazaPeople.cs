using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyWeb
{
    public class BazaPeople : DbContext
    {
        public BazaPeople ()
        {

        }

        static BazaPeople ()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BazaPeople>());
        }

        public DbSet <People> Persons { get; set; }


    }
}