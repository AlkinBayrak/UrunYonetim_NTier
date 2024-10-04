using DAL.UrunYonetimi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Context
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=vmi1229542;Database=ANK18ProductDb;Trusted_Connection=true;Trustservercertificate=true");
        }
    }
}
