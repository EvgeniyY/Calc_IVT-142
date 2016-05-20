using System;

namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Acos
    /// </summary>
    public class Acos : ICalculateFunc
    {
        /// <summary>
        /// Класс, который считает Acos.
        /// </summary>
        /// <param name="first">
        /// Аргумент Acos
        /// </param>
        /// <returns>
        /// Результат Acos
        /// </returns>
        public double CalculateFunc(double first)
        {
            return Math.Acos(first);
        }
    }
}