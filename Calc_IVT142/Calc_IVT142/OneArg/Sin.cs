using System;

namespace Calc_IVT142.OneArg

{

        public class Sin : ICalculateFunc
        {
            public double CalculateFunc(double first)
            {
                return Math.Sin(first);
            }
        }
    }