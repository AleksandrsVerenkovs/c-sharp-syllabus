using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var audi = new Audi();
            var bmw = new Bmw();
            var lexus = new Lexus();
            var tesla = new Tesla();
            var volvo = new Volvo();
            var vw = new VW();

            var carList = new List<ICar>() { audi, bmw, lexus, tesla, volvo, vw };
            carList.ForEach(car => car.StartEngine());
            for (var i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    carList.ForEach(car => { if (car is IBoost boost) { boost.UseNitrousOxideEngine(); } });
                }
                carList.ForEach(car => car.SpeedUp());
            }
            var winner = "";
            var speed = 0;
            carList.ForEach(car =>
            {
                if (int.Parse(car.ShowCurrentSpeed()) > speed)
                {
                    speed = int.Parse(car.ShowCurrentSpeed());
                    winner = car.CarBrand();
                }
            });
            Console.WriteLine($"\nWinner: {winner}; Speed: {speed}");
            Console.ReadLine();
        }
    }
}