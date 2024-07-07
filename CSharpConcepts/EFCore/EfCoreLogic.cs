using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpConcepts.EFCore
{
    public class EfCoreLogic
    {
        public static void RemoveValues()
        {
            using (var context = new OrderContext())
            {
                context.Orders.RemoveRange(context.Orders.Include(o => o.OrderItems));
                context.SaveChanges();
            }
        }
        public static void AddValues()
        {
            using (var context = new OrderContext())
            {
                var order = new Order
                {
                    OrderNumber = "12345",
                    OrderItems = new[]
                        {
                            new OrderItem { ProductName = "Product1" },
                            new OrderItem { ProductName = "Product2" }
                        }
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public static void GetValues()
        {
            using(var context = new OrderContext())
            {
                var orders = context.Orders.Include(o => o.OrderItems).ToList();
                foreach(var item in orders)
                {
                    Console.WriteLine(item.OrderNumber);
                    foreach(var item2 in item.OrderItems)
                    {
                        Console.WriteLine(item2.ProductName);
                    }
                }
            }
        }
    }
}
