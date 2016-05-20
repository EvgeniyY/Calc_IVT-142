using System;

namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Cos
    /// </summary>
        public class Cos : ICalculateFunc
        {
            /// <summary>
            /// Класс, который считает Cos.
            /// </summary>
            /// <param name="first">
            /// Аргумент Cos
            /// </param>
            /// <returns>
            /// Результат Cos
            /// </returns>
            public double CalculateFunc(double first)
            {
                return Math.Cos(first);
            }
        }
    }
