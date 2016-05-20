using System;
using Calc_IVT142.TwoArg;
using NUnit.Framework;

namespace Calc_IVT142.Tests.TwoArg
{
    public class TwoArgumentsCalculatorsFactoryTests
    {
        [TestCase("Add", typeof(Add))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("Substract", typeof(Substract))]
        [TestCase("Divide", typeof(Divide))]
        [TestCase("Log", typeof(Log))]
        
        public void FactoryTest(string name, Type type)
        {
            ICalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}