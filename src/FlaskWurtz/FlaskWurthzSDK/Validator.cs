using System;

namespace FlaskWurthzSDK
{
    public static class Validator
    {
        /// <summary>
        /// Статический метод, выполняющий проверку на соответствие значения заданного диапозону
        /// <para> Если значение не прошло валидацию, выбрасывает исключение </para>
        /// </summary>
        /// <param name="minValue">Минималное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="currentValue">Текущее значение</param>
        /// <param name="parameter">Проверяемый параметр</param>
        public static void AssertRangeParameters(double minValue, double maxValue, 
            double currentValue, Parameter parameter)
        {
            if (currentValue < minValue || currentValue > maxValue)
            {
                throw new ArgumentException($"Value {parameter} is out of range {minValue} - {maxValue}\n") ;
            }
        }
    }
}
