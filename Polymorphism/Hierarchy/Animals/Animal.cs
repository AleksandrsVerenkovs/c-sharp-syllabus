namespace Hierarchy.Animals
{
    public abstract class Animal
    {
        public string AnimalType { get; private set; }
        public string AnimalName { get; private set; }
        public double AnimalWeight { get; private set; }
        public int FoodEaten { get; set; }

        protected Animal(string animalType, string animalName, double animalWeight)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food.Food food);

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight:00}";
        }
    }
}
