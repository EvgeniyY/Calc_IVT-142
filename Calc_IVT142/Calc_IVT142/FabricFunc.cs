using System;

namespace Calc_IVT142
{
    public class FabricFunc
    {
        public static ICalculateFunc CreateCalculator(string name)
        {
            switch (name)
            {
                case "Cos":
                    return new Cos();
                case "Sin":
                    return new Sin();
                case "Squared":
                    return new Squared();
                case "Ln":
                    return new Ln();
                case "Tan":
                    return new Tan();
                case "Sqrt":
                    return new Sqrt();
                case "Ctan":
                    return new Ctan();
                case "Factorial":
                    return new Factorial();
                case "Exp":
                    return new Exp();
                case "Asin":
                    return new Asin();
                case "Acos":
                    return new Acos();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
