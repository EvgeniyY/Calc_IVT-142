using System;

namespace Calc_IVT142.OneArg
{

        public class Ln : ICalculateFunc
        {
            public double CalculateFunc(double first)
            {
                return Math.Log(first);
            }
        }
    }
