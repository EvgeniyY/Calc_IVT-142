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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
