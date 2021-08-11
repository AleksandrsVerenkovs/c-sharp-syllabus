using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Animals
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
            }
            FoodEaten += food.FoodAmount;
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROARR!!!");
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
