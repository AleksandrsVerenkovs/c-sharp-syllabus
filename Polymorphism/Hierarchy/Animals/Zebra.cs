using System;

namespace Hierarchy.Animals
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight,string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
            }
            FoodEaten += food.FoodAmount;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Maaany!!!");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
