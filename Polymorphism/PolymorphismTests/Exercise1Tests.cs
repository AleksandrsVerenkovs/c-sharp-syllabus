using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using MakeSounds;
using System.Collections;

namespace PolymorphismTests
{
    public class Exercise1Tests
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new Parrot(), "rhee-rheee" },
                new object[] { new Firework(),"whoosh-bang"},
                new object[] { new Radio(),"smooth-radio-voice"},
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void PlaySound_CallParrot_ReceiveCorrectSound(ISound a, string expected)
        {
            //Act
            var actual = a.PlaySound();

            //Assert
            Assert.Equal(expected,actual);
        }

    }
}
