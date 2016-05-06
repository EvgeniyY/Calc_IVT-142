using System;

namespace Calc_IVT142.OneArg
{
    public class Sqrt : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Sqrt(first);
        }
    }
}


