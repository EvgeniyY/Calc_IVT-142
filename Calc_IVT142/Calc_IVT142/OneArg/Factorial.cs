namespace Calc_IVT142.OneArg
{
    /// <summary>
    /// Factorial
    /// </summary>
    public class Factorial : ICalculateFunc
    {
        /// <summary>
        /// Класс, который считает Factorial.
        /// </summary>
        /// <param name="first">
        /// 
        /// </param>
        /// <returns></returns>
        public double CalculateFunc(double first)
        {
            double result = 1;
            for (double i = 1; i < first + 1; i++)
            {
                result = result*i;
            }
            return result;
        }
    }
}