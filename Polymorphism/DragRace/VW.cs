using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class VW:ICar
    {
        private int currentSpeed = 0;
        private string Name = "VW";
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
            Console.WriteLine("RRrrr..prr...");
        }
    }
}
