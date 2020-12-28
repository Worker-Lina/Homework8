using System;

namespace Homework8
{
    /// <summary>
    /// Класс для деления двух чисел
    /// </summary>
    public class NumberDivideService
    {
        /// <summary>
        /// Метод для деления двух чисел
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns>Int</returns>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="ArgumentException"/> 


        public int NumberDivide(int numerator, int denominator)
        {
            if (numerator == null || denominator == null)
            {
                throw new ArgumentNullException("Было передано пустое значение");
            }
            else if (denominator == 0)
            {
                throw new ArgumentException("На ноль делить нельзя!");
            }
            return numerator / denominator;
        }



    }
}
