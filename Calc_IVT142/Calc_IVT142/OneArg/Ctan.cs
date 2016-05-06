using System;

namespace Calc_IVT142.OneArg
{
    public class Ctan : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}