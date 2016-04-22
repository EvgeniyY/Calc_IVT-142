using System;

namespace Calc_IVT142
{
    public class Sqrt : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Sqrt(first);
        }
    }
}


