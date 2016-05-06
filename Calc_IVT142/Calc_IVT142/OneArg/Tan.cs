using System;

namespace Calc_IVT142.OneArg
{
    public class Tan : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Tan(first);
        }
    }
}