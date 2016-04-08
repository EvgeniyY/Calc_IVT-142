using System;

namespace Calc_IVT142
{
    public static class Fabric
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}