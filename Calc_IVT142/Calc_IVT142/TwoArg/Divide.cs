using System;

namespace Calc_IVT142.TwoArg
{
    public class Divide : ICalculator

    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль нельзя.");
            }

            return first/second;
        }
    }
}