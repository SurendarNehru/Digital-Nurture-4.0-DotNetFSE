using NUnit.Framework;
using CalcLibrary;

namespace CalcTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator? calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }
        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(-2, 2, 0)]
        [TestCase(5, -3, 2)]
        [TestCase(10, 0, 10)]
        [TestCase(0, 10, 10)]
        [TestCase(7, 8, 15)]
        [TestCase(4, -4, 0)]
        [TestCase(-5, -10, -15)]
        [TestCase(6, 3, 9)]
        [TestCase(20, 30, 50)]
        [TestCase(9, 1, 10)]
        [TestCase(100, -50, 50)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expectedresult)
        {
            Assert.That(calculator, Is.Not.Null);
            var result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedresult));
        }
        [Test]
        [Ignore("Subtraction not yet implemented.")]
        public void Subtract_NotImplemented()
        {
            Assert.Fail("This test is ignored.");
        }
    }
}