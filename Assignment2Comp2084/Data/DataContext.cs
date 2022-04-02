using Assignment2Comp2084.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2Comp2084.Data { 
    public class DataContext : DbContext
    {

        public DbSet<Employee> employees { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<TattooShop> tattooShops { get; set; }

        public DbSet<Booking> bookings { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
