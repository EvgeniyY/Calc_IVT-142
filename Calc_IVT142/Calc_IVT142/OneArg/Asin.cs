using System;

namespace Calc_IVT142
{
    public class Asin : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Asin(first);
        }
    }
}