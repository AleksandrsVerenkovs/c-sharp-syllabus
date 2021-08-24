using System;

namespace DragRace
{
    public class Lexus:ICar,IBoost
    {
        private int currentSpeed = 0;
        private string Name = "Lexus";

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

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=3;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}