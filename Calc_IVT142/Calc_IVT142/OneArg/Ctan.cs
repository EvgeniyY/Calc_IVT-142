using System;

namespace Calc_IVT142
{
    public class Ctan : ICalculateFunc
    {
        public double CalculateFunc(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}