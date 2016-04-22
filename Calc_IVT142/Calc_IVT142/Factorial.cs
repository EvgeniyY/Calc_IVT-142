using System;

namespace Calc_IVT142
{
    public class Factorial : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            double result = 1;
            for (double i = 1; i < first + 1; i++)
            {
                result = result*i;
            }
            return result;
        }
    }
}