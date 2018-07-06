using System;
using System.Collections.Generic;
using System.Linq;

namespace P1._7._AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            var productsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsCount; i++)
            {
                var productsAndPrices = Console.ReadLine().Split('-').ToArray();

                var product = productsAndPrices[0];
                var price = decimal.Parse(productsAndPrices[1]);

                if (!menu.ContainsKey(product))
                {
                    menu.Add(product, price);
                }
                else
                {
                    menu[product] = price;
                }
            }

            var customersAndProduct = Console.ReadLine();
            List<Customer> customers = new List<Customer>();

            while (customersAndProduct != "end of clients")
            {
                var inputCustomer = customersAndProduct.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var customerName = inputCustomer[0];
                var productName = inputCustomer[1];
                var productQuantity = int.Parse(inputCustomer[2]);
                bool isAdd = true;

                if (!menu.ContainsKey(productName))
                {
                    customersAndProduct = Console.ReadLine();
                    continue;
                }

                Customer currCustemer = null;

                if (!customers.Any(c => c.Name == customerName))
                {
                    currCustemer = new Customer(customerName);
                }
                else
                {
                    currCustemer = customers.First(n => n.Name == customerName);
                    isAdd = false;
                }
                

                if (!currCustemer.ShopList.ContainsKey(productName))
                {
                    currCustemer.ShopList.Add(productName, productQuantity);
                    currCustemer.Bill += productQuantity * menu[productName];
                }
                else
                {
                    currCustemer.ShopList[productName] += productQuantity;
                    currCustemer.Bill += productQuantity * menu[productName];
                }
                if (isAdd)
                {
                    customers.Add(currCustemer);
                }

                customersAndProduct = Console.ReadLine();
            }

            foreach (var buyer in customers.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{buyer.Name}");
                foreach (var item in buyer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {buyer.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {customers.Select(b => b.Bill).Sum()}");

        }
    }
    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
        
        public Customer(string name)
        {
            this.Name = name;

            this.ShopList = new Dictionary<string, int>();
        }
    }
}
