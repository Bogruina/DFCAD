using System;
using System.Collections.Generic;

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
        private double _bendLenght;

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
        private double _neckLenght;
       
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
               
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.BendDiameter);
                _bendDiameter = value;
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле длины отвода колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double BendLenght
        {
            get => _bendLenght;
            
            set 
            {
                const double minValue = 30;
                const double maxValue = 300;
               
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.BendLenght);
                _bendLenght = value;
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
                const double minValue = 20;
                const double maxValue = 170;
               
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.FlaskDiameter);
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
                const double minValue = 10;
                const double maxValue = 85;
                
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.NeckDiameter);
                _neckDiameter = value;
            }
        }

        /// <summary>
        /// Свойство обрабатывающее поле длины горла колбы,
        /// Содержит валидацию доспустимых значений
        /// </summary>
        public double NeckLenght
        {
            get => _neckLenght;
            
            set
            {
                const double minValue = 40;
                const double maxValue = 200;
                
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.NeckLenght);
                _neckLenght = value;
            }
        }
       

    }
}
