using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDbContext dbContext = new CustomerDbContext();
            dbContext.Database.EnsureCreated();
            Customer cust = new Customer();
            cust.Id = 3;
            cust.Name = "Hana";
            dbContext.Add(cust);  // In Memory
            dbContext.SaveChanges(); // Physical Commit*/



            List<Customer> lstCustomers = (from lsCust in dbContext.Customers
                                          select lsCust).ToList();
        }
    }
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // This will set Identity column as No - So no need increment
        public int Id { get; set; }

        public string Name { get; set; }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-C27U7D67\\SQLEXPRESS;Initial Catalog=EfCore;Integrated Security=True");
        }
        //Mapping 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }

       
    }
}
