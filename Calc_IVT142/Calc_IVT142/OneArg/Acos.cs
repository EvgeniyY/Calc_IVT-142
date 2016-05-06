using System;

namespace Calc_IVT142.OneArg
{
    public class Acos : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Acos(first);
        }
    }
}