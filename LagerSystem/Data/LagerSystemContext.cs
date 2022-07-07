using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LagerSystem.Models;
using LagerSystem.Models.ViewModel;

namespace LagerSystem.Data

{

    public class LagerSystemContext : DbContext
    {
        public LagerSystemContext(DbContextOptions<LagerSystemContext> options)
            : base(options)
        {
        }

        public DbSet<LagerSystem.Models.Products>? Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData(
                new Products { Id = 1, Name = "SWEETS", Price = 30, Orderdate = DateTime.Parse("1995-03-20"), Category = "FOOD", Shelf = "2", Count = 100, Description = "" },
                new Products { Id = 2, Name = "T-SHIRT", Price = 30, Orderdate = DateTime.Parse("1995-06-20"), Category = "SHOPPING", Shelf = "2", Count = 100, Description = "" },
                new Products { Id = 3, Name = "TROUSER", Price = 30, Orderdate = DateTime.Parse("1995-04-20"), Category = "SHOPPING", Shelf = "2", Count = 100, Description = "" },
                new Products { Id = 4, Name = "MEAT", Price = 30, Orderdate = DateTime.Parse("1995-03-26"), Category = "FOOD", Shelf = "2", Count = 100, Description = "" }


                );

        }
    }
} 

