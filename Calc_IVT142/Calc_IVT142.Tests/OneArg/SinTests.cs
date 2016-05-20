using Calc_IVT142.OneArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.OneArg
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(3, 0.141120)]
        [TestCase(0.5, 0.479426)]
        [TestCase(0.12345, 0.123137)]
        public void SinTest(double first, double expected)
        {
            ICalculateFunc calculateFunc = new Sin();
            double result = calculateFunc.CalculateFunc(first);
            Assert.AreEqual(expected,result,0.000001);
        }
         
    }
}