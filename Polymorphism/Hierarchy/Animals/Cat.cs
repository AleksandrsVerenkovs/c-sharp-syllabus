using System;

namespace Hierarchy.Animals
{
    public class Cat : Felime
    {
        private string _breed;
        public Cat(string animalType, string animalName, double animalWeight,string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            _breed = breed;
        }
        public override void Eat(Food.Food food)
        {
            FoodEaten += food.FoodAmount;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {_breed}, {AnimalWeight}, {Region}, {FoodEaten}]";
        }
    }
}
