using System;

namespace Hierarchy.Animals
{
    public class Mouse: Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight,string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
                return;
            }
            FoodEaten += food.FoodAmount;
        }
        public override string MakeSound()
        {
            return "Pfheee";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
