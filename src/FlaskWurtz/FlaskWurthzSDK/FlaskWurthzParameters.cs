using System;
using System.Runtime.CompilerServices;

namespace FlaskWurthzSDK
{
    public class FlaskWurthzParameters
    {
        /// <summary>
        /// Поле, хранящее параметр диаметера отвода колбы
        /// </summary>
        private double _bendDiameter;

        /// <summary>
        /// Поле, хранящее параметр длины отвода колбы
        /// </summary>
        private double _bendLength;

        /// <summary>
        /// Поле, хранящее параметр диаметра колбы
        /// </summary>
        private double _flaskDiameter;

        /// <summary>
        /// Поле, хранящее параметр диаметра горла колбы
        /// </summary>
        private double _neckDiameter;

        /// <summary>
        /// Поле, хранящее параметр длины горла колбы
        /// </summary>
        private double _neckLength;
       
        /// <summary>
        /// Свойство обрабатывающее поле диаметра отвода колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double BendDiameter
        {
            get => _bendDiameter;
            
            set 
            {
                const double minValue = 5;
                const double maxValue = 30;
                SetValue(ref _bendLength, value,
                    minValue, maxValue, ParameterName.BendDiameter);
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле длины отвода колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double BendLength
        {
            get => _bendLength;
            
            set 
            {
                const double minValue = 30;
                SetValue(ref _bendLength,value,minValue, 
                    FlaskDiameter + NeckLength,ParameterName.BendLength);
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле диаметра колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double FlaskDiameter
        {
            get => _flaskDiameter;
            
            set 
            {
                const double maxValue = 170;
                SetValue(ref _flaskDiameter,value, 
                    2 * NeckDiameter,maxValue,ParameterName.FlaskDiameter);
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле диаметра горла колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double NeckDiameter
        {
            get => _neckDiameter;
            
            set 
            {
                const double maxValue = 85;
                SetValue(ref _neckDiameter,value, 
                    BendDiameter + 5.0,maxValue,ParameterName.NeckDiameter);
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле длины горла колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double NeckLength
        {
            get => _neckLength;
            
            set
            {
                const double minValue = 40;
                const double maxValue = 200;
                SetValue(ref _neckLength, value, minValue, maxValue,
                    ParameterName.NeckLength);
            }
        }
        /// <summary>
        /// Устанавливает значение в требуемое свойство
        /// </summary>
        /// <param name="property">Текущее свойство</param>
        /// <param name="value">Текущее значение</param>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="parameter">Название параметра</param>
        private void SetValue(ref double property, double value,
            double minValue, double maxValue, ParameterName parameter)
        {
            Validator.AssertRangeParameters(minValue,maxValue,value,parameter);
            property = value;
        }
    }
}
