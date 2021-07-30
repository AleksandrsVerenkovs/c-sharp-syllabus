using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {

            var Max = new Dog("Max", "male");
            var Rocky = new Dog("Rocky", "male");
            var Sparky = new Dog("Sparky", "male");
            var Buster = new Dog("Buster", "male");
            var Sam = new Dog("Sam", "male");
            var Lady = new Dog("Lady", "female");
            var Molly = new Dog("Molly", "female");
            var Coco = new Dog("Coco", "female");

            Max.Mother = Lady.Name;
            Max.Father = Rocky.Name;

            Coco.Mother = Molly.Name;
            Coco.Father = Buster.Name;

            Rocky.Mother = Molly.Name;
            Rocky.Father = Sam.Name;

            Buster.Mother = Lady.Name;
            Buster.Father = Sparky.Name;

            Console.WriteLine($"Busters father: {Buster.FathersName()}");
            Console.WriteLine($"Coco has same mother as Rocky: {Coco.HasSameMotherAs(Rocky)}");
            Console.ReadKey();
        }
        public class Dog
        {
            private string _Name;
            private string Sex;
            private string _Father;
            private string _Mother;

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public string Father
            {
                private get { return _Father; }
                set { _Father = value; }
            }
            public string Mother
            {
                private get { return _Mother; }
                set { _Mother = value; }
            }
            public Dog(string name, string sex)
            {
                _Name = name;
                Sex = sex;
            }
            public Dog(string name, string sex, string father = null, string mother = null)
            {
                Name = name;
                Sex = sex;
                Father = father;
                Mother = mother;
            }
            public string FathersName()
            {
                var result = "Unknown";
                if (Father != null) result = Father;
                return result;
            }
            public bool HasSameMotherAs(Dog otherDog)
            {
                return Mother == otherDog.Mother;
            }
        }
    }
}
