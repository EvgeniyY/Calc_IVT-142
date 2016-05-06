using Calc_IVT142.TwoArg;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new Multiply();
            double result = calculator.Calculate(33, 10);
            Assert.AreEqual(330,result);
        }
         
    }
}