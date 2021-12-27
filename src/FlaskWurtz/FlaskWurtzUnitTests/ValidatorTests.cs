using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaskWurthzSDK;
using NUnit.Framework;

namespace FlaskWurtzUnitTests
{
    /// <summary>
    /// Класс хранит в себе методы для тестирования класса Validator
    /// </summary>
    [TestFixture]
    class ValidatorTests
    {
        [TestCase(10,15,20,ParameterName.FlaskDiameter, 
            TestName = "Value less than range")]
        [TestCase(100,1,50, ParameterName.FlaskDiameter,
            TestName = "Value over than range")]
        public void TestValidator_InvalidValue(double invalidValue, 
            double minValue, double maxValue, ParameterName parameter)
        {

            Assert.Throws<ArgumentException>(() => Validator.AssertRangeParameters(minValue,maxValue,
                    invalidValue,parameter), $"value out of range");
        }

        [TestCase(10, 1, 20, ParameterName.FlaskDiameter,
            TestName = "Value in the range")]
        public void TestValidator_ValidValue(double validValue,
            double minValue, double maxValue, ParameterName parameter)
        {

            Assert.DoesNotThrow(() => Validator.AssertRangeParameters(minValue, maxValue,
                validValue, parameter), $"value out of range");
        }
    }
}
