﻿using System;

namespace Calc_IVT142.OneArg
{
        public class Squared : ICalculateFunc
        {
            public double CalculateFunc(double first)
            {
                return Math.Pow(first, 2);
            }
        }
    }
