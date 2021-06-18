using Furndaqaaqas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furndaqaaqas.Data
{
    public class ExampleDB:DbContext
    {
        public ExampleDB(DbContextOptions options):base(options)
        {

        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BestProduct> BestProducts { get; set; }
    }
}
