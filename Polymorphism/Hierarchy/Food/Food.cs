namespace Hierarchy.Food
{
    public abstract class Food
    {

        public int FoodAmount { get; set; }
        public Food(int foodAmount)
        {
            FoodAmount = foodAmount;
        }
    }
}
