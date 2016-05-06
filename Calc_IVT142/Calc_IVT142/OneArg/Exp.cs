using System;

namespace Calc_IVT142.OneArg
{
    public class Exp : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Exp(first);
        }
    }
}