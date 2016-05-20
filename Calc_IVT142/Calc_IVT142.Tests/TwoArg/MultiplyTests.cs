using Calc_IVT142.TwoArg;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class MultiplyTests
    {
        [TestCase(33,10,330)]
        [TestCase(100, 0, 0)]
        [TestCase(152, 1.6, 243.2)]
        public void MultiplyTest(double first, double second, double expected)
        {
            ICalculator calculator = new Multiply();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
         
    }
}