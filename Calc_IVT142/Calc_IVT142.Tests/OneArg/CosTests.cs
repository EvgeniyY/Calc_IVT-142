using System;
using Calc_IVT142.OneArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.OneArg
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosTest()
        {
            ICalculateFunc calculateFunc = new Cos();
            double result = calculateFunc.CalculateFunc(0.5);
            Assert.AreEqual(0.87758256,result,0.00000001);
        }
         
    }
}