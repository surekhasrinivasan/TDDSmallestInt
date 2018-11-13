using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
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
            //var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            //var finder = new Finder();
            var input = new int[1] { 1 };
            var output = finder.FindSmallestInt(input);
            var expected = 1;

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            //var finder = new Finder();
            var input = new int[2] { 3, 2 };
            var output = finder.FindSmallestInt(input);
            var expected = 2;

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            //var finder = new Finder();
            var input = new int[3] { 5, 3, 1 };
            var output = finder.FindSmallestInt(input);
            var expected = 1;

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            //var finder = new Finder();
            var input = new int[7] { 2, 5, 3, 1, 6, 9, 4 };
            var output = finder.FindSmallestInt(input);
            var expected = 1;

            Assert.AreEqual(expected, output);
        }
    }
}