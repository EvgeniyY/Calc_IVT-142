using Calc_IVT142.OneArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.OneArg
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void SimpleTests()
        {
            ICalculateFunc calculateFunc = new Sin();
            double result = calculateFunc.CalculateFunc(0.5);
            Assert.AreEqual(0.479425,result,0.000001);
        }
         
    }
}