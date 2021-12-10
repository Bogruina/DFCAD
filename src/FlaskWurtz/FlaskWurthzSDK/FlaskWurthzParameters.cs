using System;

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
               
                Validator.AssertRangeParameters(minValue, maxValue, 
                    value, ParameterName.BendDiameter);
                _bendDiameter = value;
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
               
                Validator.AssertRangeParameters(minValue, 
                    FlaskDiameter+NeckLength, value, 
                    ParameterName.BendLength);
                _bendLength = value;
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
               
                Validator.AssertRangeParameters(2*NeckDiameter,
                    maxValue, value, ParameterName.FlaskDiameter);
                _flaskDiameter = value;
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
                
                Validator.AssertRangeParameters(BendDiameter + 5.0,
                    maxValue, value, ParameterName.NeckDiameter);
                _neckDiameter = value;
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
                
                Validator.AssertRangeParameters(minValue, 
                    maxValue, value, ParameterName.NeckLength);
                _neckLength = value;
            }
        }
    }
}
