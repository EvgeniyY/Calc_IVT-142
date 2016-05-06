using System;

namespace Calc_IVT142.OneArg
{
        public class Cos : ICalculateFunc
        {
            public double CalculateFunc(double first)
            {
                return Math.Cos(first);
            }
        }
    }
