using NUnit.Framework;
using System;
using WebApp.Services;

namespace WebApp.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Services.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Services.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguements()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArguement(int a, int b, int expectedResult)
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        //Seperate way of running Max_WhenCalled_ReturnGreaterArguement test individually

        [Test]
        [Ignore("Because I have it already")] // this line means the test will not run
        public void Max_FirstArguementIsGreater_ReturnFirstArguement()
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Because I have it already")]
        public void Max_SecondArguementIsGreater_ReturnSecondArguement()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Because I have it already")]
        public void Max_ArguementsAreEqual_ReturnSameArguement()
        {
            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); // preferred way of Assertion

            //OR

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
        }
    }
}
