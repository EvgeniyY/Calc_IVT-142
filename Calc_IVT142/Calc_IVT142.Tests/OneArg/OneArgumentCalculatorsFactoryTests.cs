using System;
using Calc_IVT142.OneArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.OneArg
{
    public class OneArgumentCalculatorsFactoryTests
    {
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Squared", typeof(Squared))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Ctan", typeof(Ctan))]
        [TestCase("Factorial", typeof(Factorial))]
        [TestCase("Exp", typeof(Exp))]
        [TestCase("Asin", typeof(Asin))]
        [TestCase("Acos", typeof(Acos))]
        public void SinTest(string name, Type type)
        {
            ICalculateFunc calculateFunc = OneArgumentCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculateFunc);
        } 
    }
}