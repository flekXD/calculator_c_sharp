using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Calculator; // Assuming this is the correct namespace for your Calculator class

namespace Unit_Testing_Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            calculator = new Calculator();
            calculator.First = 10;
            calculator.Second = 20;
        }

        [TestMethod]
        public void Sum_10and20_Returns30()
        {
            // Arrange
            char operation = '+';
            double expected = 30;

            // Act
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_20from10_ReturnsMinus10()
        {
            // Arrange
            char operation = '-';
            double expected = -10;

            // Act
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_20and10_Returns200()
        {
            // Arrange
            char operation = '*';
            double expected = 200;

            // Act
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Devide_20and10_Returns2()
        {
            // Arrange
            char operation = '/';
            double expected = 2;

            // Act
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidOperation_ReturnsNaN()
        {
            // Arrange
            char operation = 'f';
            double expected = double.NaN;

            // Act
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
