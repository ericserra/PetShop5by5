using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Dal
{
    public class PetShopContext : DbContext
    {
        public PetShopContext() : base("PetShopContext")
        {
        }
        public DbSet<Pet> Pets { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<Schedule> Schedules { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Services> Services { set; get; }

    }
}