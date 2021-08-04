using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volvo:ICar,IBoost
    {
        private int currentSpeed = 0;
        private string Name = "Volvo";

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
            currentSpeed += 2;
        }
        public void StartEngine()
        {
            Console.WriteLine("FRrr...sandals..and..socks");
        }
    }
}
