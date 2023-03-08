using Microsoft.EntityFrameworkCore;
using LABA333.Models;
using System.Collections.Generic;
using System.Numerics;

namespace LABA333.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
       
        {
            //Database.EnsureCreated();
        }
    } 
}