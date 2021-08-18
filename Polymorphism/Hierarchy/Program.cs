using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalLoop();
            Console.ReadKey();
        }

        public static void AnimalLoop()
        {
            var animalList = new List<string>();

            Console.WriteLine("Enter info: {AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]");
            Console.WriteLine("Type 'END' to exit.");
            do
            {
                Console.WriteLine("\nEnter animal info OR exit[type 'END'].");
                var input = Console.ReadLine().Split().Where(line => line != string.Empty).ToList();

                if (input[0] == "END")
                {
                    Console.WriteLine(string.Join(",", animalList));
                    return;
                }
                var animal = FilterAnimal(input);
                Console.WriteLine(animal.MakeSound());
                var foodGiven = FeedAnimal();
                animal.Eat(foodGiven);
                animalList.Add(animal.ToString());

            } while (true);
        }

        public static Animals.Animal FilterAnimal(List<string> animal)
        {
            var type = animal[0];
            var name = animal[1];
            var weight = double.Parse(animal[2]);
            var region = animal[3];

            switch (type)
            {
                case "Mouse":
                    return new Animals.Mouse(type, name, weight, region);
                case "Zebra":
                    return new Animals.Zebra(type, name, weight, region);
                case "Tiger":
                    return new Animals.Tiger(type, name, weight, region);
                case "Cat":
                    var breed = animal[4];
                    return new Animals.Cat(type, name, weight, region, breed);
                default:
                    throw new ArgumentException($"{type}is not valid!");
            }
        }

        public static Food.Food FeedAnimal()
        {
            Console.WriteLine("Feed animal: [Vegetable/Meat Amount]");
            var input = Console.ReadLine().Split().Where(line => line != string.Empty).ToList();

            var type = input[0];
            var amount = int.Parse(input[1]);

            switch (type)
            {
                case "Meat":
                    return new Food.Meat(amount);
                default:
                    return new Food.Vegetable(amount);
            }
        }
    }
}