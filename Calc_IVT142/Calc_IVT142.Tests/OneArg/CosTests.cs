using System;
using Calc_IVT142.OneArg;
using Calc_IVT142.TwoArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.OneArg
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(7,0.753902)]
        [TestCase(0.75, 0.731689)]
        [TestCase(0,1)]
        [TestCase(1, 0.540302)]
        public void CosTest(double first, double expected)
        {
            ICalculateFunc calculateFunc = new Cos();
            double result = calculateFunc.CalculateFunc(first);
            Assert.AreEqual(expected,result,0.000001);
        }

    }
}