using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<APizzaModel> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
           builder.UseSqlServer("Server=tcp:p0secondserver.database.windows.net,1433;Initial Catalog=lcatPizzaWorldDB;Persist Security Info=False;User ID=sysadmin;Password=Abcd1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"); 
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityID);
            builder.Entity<User>().HasKey(u => u.EntityID);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityID);
            builder.Entity<Order>().HasKey(o => o.EntityID);
        
            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        { 
            builder.Entity<Store>().HasData(new List<Store>
            {
                new Store() { EntityID = 1, Name = "One" },
                new Store() { EntityID = 2, Name = "Two" },
                new Store() { EntityID = 3, Name = "Three"}
            }
            );
        }



    }
}