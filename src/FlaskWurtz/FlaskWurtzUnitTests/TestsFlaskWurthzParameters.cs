using System;
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
                NeckLength = 40
            };

        #region [Positive tests]

        [TestCase(45, TestName = "Flask Diameter getter positive test")]
        public void TestFlaskDiameter_CorrectSetValue(double correctValue)
        {
            var flask = DefaultParameters;
            var value = correctValue;
            var expected = correctValue;

            flask.FlaskDiameter = value;
            var actual = flask.FlaskDiameter;

            Assert.AreEqual(expected, actual, $"{nameof(flask.FlaskDiameter)}" +
                $"returns wrong value");
        }

        [TestCase(TestName = "Bend Diameter getter positive test")]
        public void TestBendDiameter_CorrectSetValue()
        {
            var flask = DefaultParameters;
            var value = DefaultParameters.BendDiameter;
            var expected = DefaultParameters.BendDiameter;

            flask.BendDiameter = value;
            var actual = flask.BendDiameter;

            Assert.AreEqual(expected, actual, $"{nameof(flask.BendDiameter)}" +
                $"returns wrong value");
        }

        [TestCase(TestName = "Bend Length getter positive test")]
        public void TestBendLength_CorrectSetValue()
        {
            var flask = DefaultParameters;
            var value = DefaultParameters.BendLength;
            var expected = DefaultParameters.BendLength;

            flask.BendLength = value;
            var actual = flask.BendLength;

            Assert.AreEqual(expected, actual, $"{nameof(flask.BendLength)}" +
                $"returns wrong value");
        }

        [TestCase(TestName = "Neck Diameter getter positive test")]
        public void TestNeckDiameter_CorrectSetValue()
        {
            var flask = DefaultParameters;
            var value = DefaultParameters.NeckDiameter;
            var expected = DefaultParameters.NeckDiameter;

            flask.NeckDiameter = value;
            var actual = flask.NeckDiameter;

            Assert.AreEqual(expected, actual, $"{nameof(flask.NeckDiameter)}" +
                $"returns wrong value");
        }

        [TestCase(TestName = "Neck Length getter positive test")]
        public void TestNeckLength_CorrectSetValue()
        {
            var flask = DefaultParameters;
            var value = DefaultParameters.NeckLength;
            var expected = DefaultParameters.NeckLength;

            flask.NeckLength = value;
            var actual = flask.NeckLength;

            Assert.AreEqual(expected, actual, $"{nameof(flask.NeckLength)}" +
                $"returns wrong value");
        }
        #endregion

        #region [Negative tests]

        [TestCase(250, TestName = "Flask diameter value less than range")]
        [TestCase(1, TestName = "Flask diameter value over than range")]
        public void TestFlaskDiameter_InvalidSetValue(double invalidValue)
        {
            var flask = DefaultParameters;

            Assert.Throws<ArgumentException>(() => flask.FlaskDiameter = invalidValue,
                $"value out of range");
        }

        [TestCase(40, TestName = "Bend Diameter value less than range")]
        [TestCase(3, TestName = "Bend Diameter value over than range")]
        public void TestBendDiameter_InvalidSetValue(double invalidValue)
        {
            var flask = DefaultParameters;

            Assert.Throws<ArgumentException>(() => flask.BendDiameter = invalidValue,
                $"value out of range");
        }

        [TestCase(301, TestName = "Bend Length value less than range")]
        [TestCase(28, TestName = "Bend Length value over than range")]
        public void TestBendLength_InvalidSetValue(double invalidValue)
        {
            var flask = DefaultParameters;

            Assert.Throws<ArgumentException>(() => flask.BendLength = invalidValue,
                $"value out of range");
        }

        [TestCase(100, TestName = "Neck Diameter value less than range")]
        [TestCase(9, TestName = "Neck Diameter value over than range")]
        public void TestNeckDiameter_InvalidSetValue(double invalidValue)
        {
            var flask = DefaultParameters;

            Assert.Throws<ArgumentException>(() => flask.NeckDiameter = invalidValue,
                $"value out of range");
        }

        [TestCase(201, TestName = "Neck Length value less than range")]
        [TestCase(39, TestName = "Neck Length value over than range")]
        public void TestNeckLength_InvalidSetValue(double invalidValue)
        {
            var flask = DefaultParameters;

            Assert.Throws<ArgumentException>(() => flask.NeckLength = invalidValue,
                $"value out of range");
        }
        #endregion
    }
}
