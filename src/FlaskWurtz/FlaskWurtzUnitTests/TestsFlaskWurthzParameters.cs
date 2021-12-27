using System;
using System.Reflection;
using NUnit.Framework;
using FlaskWurthzSDK;

namespace FlaskWurtzUnitTests
{
    /// <summary>
    /// Класс хранит методы для тестирования FlaskWurthParameters
    /// </summary>
    [TestFixture]
    public class TestsFlaskWurthzParameters
    {
        private FlaskWurthzParameters DefaultParameters =>
            new FlaskWurthzParameters()
            {
                FlaskDiameter = 45,
                BendDiameter = 5,
                BendLength = 35,
                NeckDiameter = 10,
                NeckLength = 40,
                NumberBends = 1
            };

        #region [Positive tests]

        [TestCase(45, ParameterName.FlaskDiameter, 
            TestName = "Flask Diameter getter positive test")]
        [TestCase(5,ParameterName.BendDiameter,
            TestName = "Bend Diameter getter positive test")]
        [TestCase(30,ParameterName.BendLength,
            TestName = "Bend Length getter positive test")]
        [TestCase(2,ParameterName.NumberBends,
            TestName = "Number Bends getter positive test")]
        [TestCase(10,ParameterName.NeckDiameter,
            TestName = "Neck Diameter getter positive test")]
        [TestCase(40, ParameterName.NeckLength,
            TestName = "Neck Length getter positive test")]
        public void TestParametersFlaskWurthz_CorrectSetValue(double correctValue, ParameterName parameter)
        {
            // Arrange
            var defaultParameters = DefaultParameters;
            var value = correctValue;
            var expected = correctValue;

            // Act
            var propertyInfo = typeof(FlaskWurthzParameters).
                GetProperty(parameter.ToString());
            propertyInfo.SetValue(defaultParameters, value);

            var actual = propertyInfo.GetValue(defaultParameters);

            //Assert
            Assert.AreEqual(expected, actual, $"{nameof(propertyInfo)}" +
                $"returns wrong value");
        }
        #endregion

        #region [Negative tests]

        [TestCase(250,ParameterName.FlaskDiameter, 
            TestName = "Flask diameter value less than range")]
        [TestCase(1, ParameterName.FlaskDiameter, 
            TestName = "Flask diameter value over than range")]
        [TestCase(40, ParameterName.BendDiameter,
            TestName = "Bend Diameter value less than range")]
        [TestCase(3, ParameterName.BendDiameter,
            TestName = "Bend Diameter value over than range")]
        [TestCase(301, ParameterName.BendLength, 
            TestName = "Bend Length value less than range")]
        [TestCase(28, ParameterName.BendLength,
            TestName = "Bend Length value over than range")]
        [TestCase(100,ParameterName.NeckDiameter, 
            TestName = "Neck Diameter value less than range")]
        [TestCase(9, ParameterName.NeckDiameter, 
            TestName = "Neck Diameter value over than range")]
        [TestCase(201,ParameterName.NeckLength,
            TestName = "Neck Length value less than range")]
        [TestCase(39, ParameterName.NeckLength,
            TestName = "Neck Length value over than range")]
        [TestCase(0,ParameterName.NumberBends,
            TestName = "Number Bends value less than range")]
        [TestCase(5, ParameterName.NumberBends,
            TestName = "Number Bends value over than range")]
        public void TestParametersFlaskWurthz_InvalidSetValue(double invalidValue, ParameterName parameter)
        {
            // Arrange
            var defaultParameters = DefaultParameters;
            var propertyInfo = typeof(FlaskWurthzParameters).
                GetProperty(parameter.ToString());

            //Assert
           var ex = Assert.Throws<TargetInvocationException>(() => 
                propertyInfo.SetValue(defaultParameters, invalidValue),
                $"value out of range");

        }
        #endregion
    }
}
