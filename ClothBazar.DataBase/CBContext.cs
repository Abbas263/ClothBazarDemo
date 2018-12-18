using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClothBazar.Entities;

namespace ClothBazar.DataBase
{
    class CBContext:DbContext
    {
        public CBContext(): base("ClothBazarConnection")
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
