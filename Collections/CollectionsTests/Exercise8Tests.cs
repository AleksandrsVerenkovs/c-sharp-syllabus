using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using PhoneBook;

namespace CollectionsTests
{
    public class Exercise8Tests
    {
        [Fact]
        public void GetNumber_ProvideInvalidName_ReturnErrorMsg()
        {
            //Arrange
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "3565460");
            //Act
            var expected = "Number wasn't found";
            var actual = newPhoneBook.GetNumber("Gabriel");
            //Assert
            Assert.Equal(actual,expected);
        }

        [Fact]
        public void GetNumber_ProvideName_ReturnsNumber()
        {
            //Arrange
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "1234");
            //Act
            var expected = "1234";
            var actual = newPhoneBook.GetNumber("Annabell");
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PutNumber_NewPersonNumber_OverwritesOldNumber()
        {
            //Arrange
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "1234");
            var expected = "4321";
            //Act
            newPhoneBook.PutNumber("Annabell","4321");
            var actual = newPhoneBook.GetNumber("Annabell");
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
