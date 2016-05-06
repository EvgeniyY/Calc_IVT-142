using Calc_IVT142.TwoArg;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class DivideTests
    {
        [Test]
        public void SimpleTest()
        {
            double result;
            ICalculator calculator = new Divide();
            result = calculator.Calculate(27, 3);
            Assert.AreEqual(9,result);
        }

    }
}
