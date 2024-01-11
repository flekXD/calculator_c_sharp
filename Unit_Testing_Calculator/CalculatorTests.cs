using Class_Calculator;

namespace Unit_Testing_Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_Returns30()
        {
            // Arrange
            double x = 10;
            double y = 20;
            char operation = '+';
            double expected = 30;

            // Act
            Calculator calculator = new Calculator();
            calculator.First = x;
            calculator.Second = y;
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_20from10_ReturnsMinus10()
        {
            // Arrange
            double x = 10;
            double y = 20;
            char operation = '-';
            double expected = -10;

            // Act
            Calculator calculator = new Calculator();
            calculator.First = x;
            calculator.Second = y;
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_5and4_Returns20()
        {
            // Arrange
            double x = 5;
            double y = 4;
            char operation = '*';
            double expected = 20;

            // Act
            Calculator calculator = new Calculator();
            calculator.First = x;
            calculator.Second = y;
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidOperation_ReturnsNaN()
        {
            // Arrange
            double x = 8;
            double y = 4;
            char operation = 'f';
            double expected = double.NaN;

            // Act
            Calculator calculator = new Calculator();
            calculator.First = x;
            calculator.Second = y;
            double actual = calculator.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}