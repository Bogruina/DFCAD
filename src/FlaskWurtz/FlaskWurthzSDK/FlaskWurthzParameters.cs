using System;
using System.Collections.Generic;

namespace FlaskWurthzSDK
{
    public class FlaskWurthzParameters
    {
        private double _bendDiameter;

        private double _bendLenght;

        private double _flaskDiameter;

        private double _neckDiameter;

        private double _neckLenght;
       
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

        public double FlaskDiameter
        {
            get => _flaskDiameter;
            
            set 
            {
                const double minValue = 20;
                const double maxValue = 100;
               
                Validator.AssertRangeParameters(minValue, maxValue, value, Parameter.FlaskDiameter);
                _flaskDiameter = value;
            }
        }

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
