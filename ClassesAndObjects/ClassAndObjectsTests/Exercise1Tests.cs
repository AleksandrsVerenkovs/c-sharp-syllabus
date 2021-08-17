using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Exercise1;
using System.Collections;

namespace ClassAndObjectsTests
{
    public class TestGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Tuple<string,double,int>("Mouse",70.00,3),
            };
            yield return new object[]
            {
                new Tuple<string,double,int>("Keyboard",54.40,6),
            };
            yield return new object[]
            {
                new Tuple<string,double,int>("Pad",9.99,1)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class Exercise1Tests
    {
        [Theory]
        [ClassData(typeof(TestGenerator))]
        public void PrintProduct_ReturnsFullInfo(Tuple<string, double, int> tuple)
        {
            var prod = new Exercise1.Program.Product(tuple.Item1, tuple.Item2, tuple.Item3);
            var expected = $"{tuple.Item1}, price {tuple.Item2}, amount {tuple.Item3}";
            var actual = prod.PrintProduct();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(TestGenerator))]
        public void ChangePrice_ChangesPriceTo10(Tuple<string, double, int> tuple)
        {
            var changedValue = 10.00;

            var prod = new Exercise1.Program.Product(tuple.Item1, tuple.Item2, tuple.Item3);
            prod.ChangePrice(changedValue);

            var expected = $"{tuple.Item1}, price {changedValue}, amount {tuple.Item3}";
            var actual = prod.PrintProduct();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(TestGenerator))]
        public void ChangeAmount_ChangesAmountTo5(Tuple<string, double, int> tuple)
        {
            var changedValue = 5;

            var prod = new Exercise1.Program.Product(tuple.Item1, tuple.Item2, tuple.Item3);
            prod.ChangeAmount(changedValue);

            var expected = $"{tuple.Item1}, price {tuple.Item2}, amount {changedValue}";
            var actual = prod.PrintProduct();

            Assert.Equal(expected, actual);
        }
    }
}
