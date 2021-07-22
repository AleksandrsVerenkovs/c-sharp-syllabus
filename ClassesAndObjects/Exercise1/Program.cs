using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        { 
            var arr = new Dictionary<int, Tuple<string,double,int>>();
            arr.Add(1, new Tuple<string, double, int>("Logitech mouse", 70.00, 14));
            arr.Add(2, new Tuple<string, double, int>("iPhone 5s", 999.99, 3));
            arr.Add(3, new Tuple<string, double, int>("Epson EB-U05", 440.46, 1));

            foreach( var item in arr)
            {
                var prod = new Product(item.Value.Item1, item.Value.Item2, item.Value.Item3);
                prod.PrintProduct();
                prod.ChangePrice(33.3);
                prod.ChangeAmount(22);
                prod.PrintProduct();
            }
            Console.ReadLine();
        }
        class Product 
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
            public void PrintProduct()
            {
                Console.WriteLine($"{Name}, price {PriceAtStart}, amount {AmountAtStart}");
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
