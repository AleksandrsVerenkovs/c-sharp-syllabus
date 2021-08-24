using System;

namespace Hierarchy.Animals
{
    public abstract class Mammal : Animal
    {
        public string Region { get; private set; }
        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion = "") : base(animalType, animalName, animalWeight)
        {
            Region = livingRegion;
        }
        public override string ToString()
        {
            var msg = base.ToString();
            return $"{msg}, {Region}, {FoodEaten}]";
        }
    }
}
