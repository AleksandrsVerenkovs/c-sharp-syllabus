using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Hierarchy;
using Hierarchy.Animals;
using Hierarchy.Food;

namespace PolymorphismTests
{
    public class Exercise6Tests
    {
        public static IEnumerable<object[]> AnimalData =>
            new List<object[]>
            {
                new object[] { new Zebra("Zebra","Manny",40.4,"Africa"), "Zebra [Manny, 40.40, Africa, 0]"},
                new object[] { new Cat("Cat","Garfield",5.0,"House", "LazyBread"),"Cat [Garfield, LazyBread, 5.00, House, 0]"},
                new object[] { new Mouse("Mouse","Jerry",1.2,"Crack_in_the_wall"),"Mouse [Jerry, 1.20, Crack_in_the_wall, 0]"},
                new object[] { new Tiger("Tiger","Tony",60.0,"Savannah"),"Tiger [Tony, 60.00, Savannah, 0]"},
            };

        public static IEnumerable<object[]> AnimalFedMeat =>
            new List<object[]>
            {
                new object[] { new Zebra("Zebra","Manny",40.4,"Africa"), "Zebra [Manny, 40.40, Africa, 0]"},
                new object[] { new Cat("Cat","Garfield",5.0,"House", "LazyBread"),"Cat [Garfield, LazyBread, 5.00, House, 2]"},
                new object[] { new Mouse("Mouse","Jerry",1.2,"Crack_in_the_wall"),"Mouse [Jerry, 1.20, Crack_in_the_wall, 0]"},
                new object[] { new Tiger("Tiger","Tony",60.0,"Savannah"),"Tiger [Tony, 60.00, Savannah, 2]"},
            };
        public static IEnumerable<object[]> AnimalFedVegetable =>
            new List<object[]>
            {
                new object[] { new Zebra("Zebra","Manny",40.4,"Africa"), "Zebra [Manny, 40.40, Africa, 5]"},
                new object[] { new Cat("Cat","Garfield",5.0,"House", "LazyBread"),"Cat [Garfield, LazyBread, 5.00, House, 5]"},
                new object[] { new Mouse("Mouse","Jerry",1.2,"Crack_in_the_wall"),"Mouse [Jerry, 1.20, Crack_in_the_wall, 5]"},
                new object[] { new Tiger("Tiger","Tony",60.0,"Savannah"),"Tiger [Tony, 60.00, Savannah, 0]"},
            };
        public static IEnumerable<object[]> AnimalMakesSound =>
            new List<object[]>
            {
                new object[] { new Zebra("Zebra","Manny",40.4,"Africa"), "Maaany!!!"},
                new object[] { new Cat("Cat","Garfield",5.0,"House", "LazyBread"),"Meowwww"},
                new object[] { new Mouse("Mouse","Jerry",1.2,"Crack_in_the_wall"),"Pfheee"},
                new object[] { new Tiger("Tiger","Tony",60.0,"Savannah"),"ROARR!!!"},
            };

        public static IEnumerable<object[]> FoodAmount =>
            new List<object[]>
            {
                new object[] { new Meat(0), 0},
                new object[] { new Meat(5), 5},
                new object[] { new Vegetable(5), 5},
                new object[] { new Vegetable(5), 5},

            };

        public static IEnumerable<object[]> CreateAnimalData =>
            new List<object[]>
            {
                new object[] { "Zebra", "Manny", "40.4", "Africa","", new Zebra("Zebra","Manny",40.4,"Africa")},
                new object[] { "Cat", "Garfield", "5.0", "House", "LazyBread", new Cat("Cat","Garfield",5.0,"House", "LazyBread")},
                new object[] { "Mouse", "Jerry", "1.2", "Crack_in_the_wall","", new Mouse("Mouse","Jerry",1.2,"Crack_in_the_wall")},
                new object[] { "Tiger","Tony","60.0", "Savannah","",new Tiger("Tiger","Tony",60.0,"Savannah")},
            };

        [Theory]
        [MemberData(nameof(AnimalData))]
        public void ToString__ReceiveBaseInfo_ReturnBaseInfoString(Animal a, string expected)
        {
            //Act
            var actual = a.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(CreateAnimalData))]
        public void FilterAnimal_ReceiveAnimalInfo_CreateAnimalClass(string type, string name, string weight, string region, string? bread , Mammal expected)
        {
            //Act
            var list = new List<string>() { type, name, weight, region, bread };
            var actual = Hierarchy.Program.FilterAnimal(list);

            //Assert
            Assert.Equal(expected.AnimalName, actual.AnimalName);
            Assert.Equal(expected.AnimalType, actual.AnimalType);
            Assert.Equal(expected.AnimalWeight, actual.AnimalWeight);
        }

        [Theory]
        [MemberData(nameof(AnimalFedMeat))]
        public void Eat_InputMeat_AnimalsFedMeat(Animal a, string expected)
        {
            //Arrange
            var giveMeat = new Meat(2);

            //Act
            a.Eat(giveMeat);
            var actual = a.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AnimalFedVegetable))]
        public void Eat_InputVegetables_AnimalsFedVegetable(Animal a, string expected)
        {
            //Arrange
            var giveMeat = new Vegetable(5);

            //Act
            a.Eat(giveMeat);
            var actual = a.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [MemberData(nameof(AnimalMakesSound))]
        public void MakeSound_CallSoundMethod_MakesAnimalSound(Animal a, string expected)
        {
            //Act
            var actual = a.MakeSound();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(FoodAmount))]
        public void Food_Give5Food_Add5ToMeatOrVegetable(Food a, int expected)
        {
            //Act
            var actual = a.FoodAmount;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
