using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneProductDiscount = new OneProductDiscount();
            var fiveProductsDiscount = new FiveProductsDiscount();
            var tenProductsDiscount = new TenProductsDiscount();
            var noDiscount = new NoDiscount();
            
            tenProductsDiscount.NextDiscountRule = fiveProductsDiscount;
            fiveProductsDiscount.NextDiscountRule = oneProductDiscount;
            oneProductDiscount.NextDiscountRule = noDiscount;

            List<Product> products = new List<Product>();
            int totalProductsCount = 0;
            decimal totalProductsValue = 0;

            //One product
            products.Add(new Product("Item1", 100));

            totalProductsCount = products.Count;
            totalProductsValue = products.Sum(p => p.Price);

            Console.WriteLine($"Your shopping cart has {totalProductsCount} product(s) and a total of $ {totalProductsValue}. " +
                                $"You will receive $ {tenProductsDiscount.Apply(products)} of discount.");

            //Five products
            products.Add(new Product("Item2", 100));
            products.Add(new Product("Item3", 150));
            products.Add(new Product("Item4", 50));
            products.Add(new Product("Item5", 600));

            totalProductsCount = products.Count;
            totalProductsValue = products.Sum(p => p.Price);

            Console.WriteLine($"Your shopping cart has {totalProductsCount} product(s) and a total of $ {totalProductsValue}. " +
                                $"You will receive $ {tenProductsDiscount.Apply(products)} of discount.");

            //Ten or more products
            products.Add(new Product("Item6", 250));
            products.Add(new Product("Item7", 250));
            products.Add(new Product("Item8", 250));
            products.Add(new Product("Item9", 250));
            products.Add(new Product("Item10", 500));
            products.Add(new Product("Item11", 500));

            totalProductsCount = products.Count;
            totalProductsValue = products.Sum(p => p.Price);

            Console.WriteLine($"Your shopping cart has {totalProductsCount} product(s) and a total of $ {totalProductsValue}. " +
                                $"You will receive $ {tenProductsDiscount.Apply(products)} of discount.");

            Console.ReadKey();
        }
    }
}
