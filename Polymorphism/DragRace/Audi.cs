using System;

namespace DragRace
{
    public class Audi:ICar
    {
        private int currentSpeed = 0;
        private string Name = "Audi";

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
            currentSpeed++;
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