using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Car> Car {  get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
