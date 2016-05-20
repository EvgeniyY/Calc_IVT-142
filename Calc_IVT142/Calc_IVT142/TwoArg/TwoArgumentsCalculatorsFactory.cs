using System;

namespace Calc_IVT142.TwoArg
{
    public static class TwoArgumentsCalculatorsFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Add":
                    return new Add();
                case "Multiply":
                    return  new Multiply();
                case "Substract":
                    return new Substract();
                case "Divide":
                    return new Divide();
                case "Log":
                    return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}