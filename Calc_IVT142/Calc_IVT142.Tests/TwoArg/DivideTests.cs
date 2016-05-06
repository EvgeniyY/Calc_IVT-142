using Calc_IVT142.TwoArg;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class DivideTests
    {
        [TestCase(333, 3, 111)]
        [TestCase(-800, -10, 80)]
        [TestCase(20, -0.5, -40)]
        [TestCase(11, 3, 3.6666)]
        public void DivideTest(double first, double second, double expected)
        {
            ICalculator calculator = new Divide();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);

        }

    }
}
