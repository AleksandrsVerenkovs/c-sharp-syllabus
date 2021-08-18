using System;

namespace Hierarchy.Food
{
    public abstract class Food
    {

        public int FoodAmount { get; set; }
        public Food(int foodAmount)
        {
            while (foodAmount < 0)
            {
                Console.WriteLine("There's no negative food!");
            }
            FoodAmount = foodAmount;
        }
    }
}
