using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CitiesDataBase
{
    class CitiesContext : DbContext
    {
        public CitiesContext() : base("DbConnection") { }
        public DbSet<City> Cities { get; set; }
    }
}
