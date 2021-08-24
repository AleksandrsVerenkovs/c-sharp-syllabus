using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Tuple<string, double, int>>()
            {
                new Tuple<string, double, int>("Logitech mouse", 70.00, 14),
                new Tuple<string, double, int>("iPhone 5s", 999.99, 3),
                new Tuple<string, double, int>("Epson EB-U05", 440.46, 1)
            };

            list.ForEach(item =>
            {
                var prod = new Product(item.Item1, item.Item2, item.Item3);
                Console.WriteLine(prod.PrintProduct());
                prod.ChangePrice(33.3);
                prod.ChangeAmount(22);
                Console.WriteLine(prod.PrintProduct());
            });
            Console.ReadLine();
        }
        public class Product
        {
            private string Name;
            private double PriceAtStart;
            private int AmountAtStart;
            public Product(string name, double priceAtStart, int amountAtStart)
            {
                Name = name;
                PriceAtStart = priceAtStart;
                AmountAtStart = amountAtStart;
            }
            public string PrintProduct()
            {
                return $"{Name}, price {PriceAtStart}, amount {AmountAtStart}";
            }

            public void ChangePrice(double price)
            {
                PriceAtStart = price;
            }

            public void ChangeAmount(int amount)
            {
                AmountAtStart = amount;
            }
        }

    }
}
