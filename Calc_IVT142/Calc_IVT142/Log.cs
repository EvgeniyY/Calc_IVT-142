﻿using System;

namespace Calc_IVT142
{
    public class Log : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first,second);
        }
    }
}