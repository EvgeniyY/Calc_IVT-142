using Calc_IVT142.TwoArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.TwoArg
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SimpleTest()
        {
            double result;
            ICalculator calculator = new Add();
            result = calculator.Calculate(2, 2);
            Assert.AreEqual(4,result);
        }
    }
}