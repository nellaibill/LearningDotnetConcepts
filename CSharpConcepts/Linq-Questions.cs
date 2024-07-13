using CSharpConcepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class Linq_Questions
    {
        public static void question1()
        {
            List<int> lstNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = lstNumbers.Where(x => x % 2 == 0);
            Console.WriteLine("Question1 : " + string.Join(",", result));
        }
        public static void question2()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, Name = "Alice", Age = 25 },
                new Employee { EmployeeId = 2, Name = "Bob", Age = 35 },
                new Employee { EmployeeId = 3, Name = "Charlie", Age = 40 }
            };

            var result = employees.Where(x => x.Age > 30).ToList();
            result.ForEach(x => Console.WriteLine(x.Name));
        }

        public static void question3()
        {
            List<Student> students = new List<Student>
                {
                    new Student { Name = "John", Grade = "A" },
                    new Student { Name = "Jane", Grade = "B" },
                    new Student { Name = "Joe", Grade = "A" },
                    new Student { Name = "Jill", Grade = "C" }
                };

            var result = students.GroupBy(x => x.Grade).ToList();
            Console.WriteLine();
        }
        public static void question4()
        {
            List<Product> products = new List<Product>
                {
                    new Product { Name = "Product1", Price = 10.5m },
                    new Product { Name = "Product2", Price = 20.0m },
                    new Product { Name = "Product3", Price = 15.0m }
                };

            var result = products.OrderByDescending(x => x.Price).ToList();
            result.ForEach(x => Console.WriteLine(x.Name, x.Price));
        }

        public static void question5()
        {

            List<Book> books = new List<Book>
                {
                    new Book { Title = "Book1", Author = "Author1" },
                    new Book { Title = "Book2", Author = "Author2" },
                    new Book { Title = "Book3", Author = "Author3" }
                };

            books.ForEach(x => Console.WriteLine(x.Title));
        }

        public static void question6()
        {
            List<Product> products = new List<Product>
                {
                    new Product { Name = "Product1", Price = 10.5m },
                    new Product { Name = "Product2", Price = 20.0m },
                    new Product { Name = "Product3", Price = 15.0m }
                };
            var result = products.Average(x => x.Price);
            Console.WriteLine(Math.Round(result));
        }

        public static void question7()
        {

            List<Customer> customers = new List<Customer>
                {
                    new Customer { Id = 1, Name = "Customer1" },
                    new Customer { Id = 2, Name = "Customer2" }
                };

            List<Order> orders = new List<Order>
                {
                    new Order { CustomerId = 1, OrderDetails = "Order1" },
                    new Order { CustomerId = 2, OrderDetails = "Order2" }
                };


            var customerOrders = from c in customers
                                 join o in orders
                                 on c.Id equals o.CustomerId
                                 select new
                                 {
                                     c.Name,
                                     o.OrderDetails,
                                 };
            //Console.WriteLine(customerOrders.FirstOrDefault().Name);

        }

        public static void question8()
        {
            List<int> lstDetails= new List<int> { 1,2,3,4,4,4,5,6,7,8,9,10};
            var result=lstDetails.Skip(2).Take(3);
            Console.WriteLine(string.Join(",", result));
        }

        public static void question9()
        {
            List<int> lstDetails = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9, 10 };
            var result = lstDetails.Distinct();
            Console.WriteLine(string.Join(",",result));
        }
        public static void question10()
        {
            List<int> lstDetails = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9, 10 };
            var result = lstDetails.Any(x=>x>4);
            Console.WriteLine(string.Join(",", result));
        }
        public static void question11()
        {
            List<int> lstDetails = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9, 10 };
            var result = lstDetails.OrderByDescending(x=>x).Skip(1).Take(1).ToList();
            Console.WriteLine(string.Join(",",result));
        }

    }
}
