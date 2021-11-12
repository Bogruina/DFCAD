using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskWurthzSDK
{
    public static class Validator
    {
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
