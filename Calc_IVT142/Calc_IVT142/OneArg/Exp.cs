﻿using System;

namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Exp
    /// </summary>
    public class Exp : ICalculateFunc
    {
        /// <summary>
        /// Класс, который считает Exp.
        /// </summary>
        /// <param name="first">
        /// Аргумент Exp
        /// </param>
        /// <returns>
        /// Результат Exp
        /// </returns>
        public double CalculateFunc(double first)
        {
            return Math.Exp(first);
        }
    }
}