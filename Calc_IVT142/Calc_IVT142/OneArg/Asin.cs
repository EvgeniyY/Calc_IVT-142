using System;

namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Asin
    /// </summary>
    public class Asin : ICalculateFunc
    {
        /// <summary>
        /// Класс, который считает Asin.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double CalculateFunc(double first)
        {
            return Math.Asin(first);
        }
    }
}