using Calc_IVT142.TwoArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(-100, 0, -100)]
        [TestCase(256, 128, 384)]
        [TestCase(-5, -5, -10)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculator calculator = new Add();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}