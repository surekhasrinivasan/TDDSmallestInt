using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        private Finder finder;

        [SetUp]
        public void SetUpFinderTests()
        {
            finder = new Finder();
        }

        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }

        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var input = new int[1] { 1 };
            var output = finder.FindClosestIntToZero(input);
            var expected = 1;
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var input = new int[2] { 2, 3 };
            var output = finder.FindClosestIntToZero(input);
            var expected = 2;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var input = new int[3] { 5, 2, 3 };
            var output = finder.FindClosestIntToZero(input);
            var expected = 2;
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var input = new int[3] { -3, -5, -2 };
            var output = finder.FindClosestIntToZero(input);
            var expected = -2;
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var input = new int[4] { -2, 4, -1, 1 };
            var output = finder.FindClosestIntToZero(input);
            var expected = -1;
            Assert.AreEqual(expected, output);
        }
    }
}