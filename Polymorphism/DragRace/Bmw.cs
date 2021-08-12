using System;

namespace DragRace
{
    public class Bmw:ICar
    {
        private int currentSpeed = 0;
        private string Name = "BMW";

        public string CarBrand()
        {
            return Name;
        }
        public void SpeedUp() 
        {
            currentSpeed++;
        }

        public void SlowDown() 
        {
            currentSpeed--;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}