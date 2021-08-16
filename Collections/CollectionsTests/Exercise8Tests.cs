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
        public void GetNumber_ReturnErrorMsg()
        {
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "3565460");

            var expected = "Number wasn't found";
            var actual = newPhoneBook.GetNumber("Gabriel");

            Assert.Equal(actual,expected);
        }

        [Fact]
        public void GetNumber_ReturnsNumber()
        {
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "1234");

            var expected = "1234";
            var actual = newPhoneBook.GetNumber("Annabell");

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PutNumber_OverwritesOldNumber()
        {
            var newPhoneBook = new PhoneDirectory();
            newPhoneBook.PutNumber("Matt", "3565460");
            newPhoneBook.PutNumber("Rick", "3565460");
            newPhoneBook.PutNumber("Annabell", "1234");

            var expected = "4321";
            newPhoneBook.PutNumber("Annabell","4321");
            var actual = newPhoneBook.GetNumber("Annabell");

            Assert.Equal(actual, expected);
        }
    }
}
