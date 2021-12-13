using System;

namespace FlaskWurthzSDK
{
    /// <summary>
    /// Статический класс, хранит метод для валидации значений
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Статический метод, выполняющий проверку на соответствие 
        /// значения заданного диапозону
        /// <para> Если значение не прошло валидацию, выбрасывает
        /// исключение </para>
        /// </summary>
        /// <param name="minValue">Минималное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="currentValue">Текущее значение</param>
        /// <param name="parameterName">Проверяемый параметр</param>
        public static void AssertRangeParameters(double minValue,
            double maxValue, double currentValue, ParameterName parameterName)
        {
            if (currentValue < minValue || currentValue > maxValue)
            {
                throw new ArgumentException($"Value {parameterName} " +
                                            $"is out of range {minValue} - {maxValue}\n");
            }
        }
    }
}