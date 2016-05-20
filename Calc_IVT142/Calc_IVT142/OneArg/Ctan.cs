using System;

namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Ctan
    /// </summary>
    public class Ctan : ICalculateFunc
    {
        /// <summary>
        /// Класс, который считает Ctan.
        /// </summary>
        /// <param name="first">
        /// Аргумент Ctan
        /// </param>
        /// <returns>
        /// Результат Ctan
        /// </returns>
        public double CalculateFunc(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}