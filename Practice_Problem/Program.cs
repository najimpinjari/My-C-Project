using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                     new Customer { CustomerId = 1, Name = "Alice" },
                    new Customer { CustomerId = 2, Name = "Bob" }
            };

            List<Order> orders = new List<Order>
            {
            new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop" },
            new Order { OrderId = 102, CustomerId = 2, ProductName = "Tablet" }
            };

            var joinQuery = from customer in customers
                            join order in orders 
                            on customer.CustomerId equals order.CustomerId
                            select new
                            {
                                CustomerName = customer.Name,
                                OrderProduct = order.ProductName
                            };
            foreach (var item in joinQuery)
            {
                Console.WriteLine($"Customer: {item.CustomerName}, Product: {item.OrderProduct}");
            }
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
    }
}
