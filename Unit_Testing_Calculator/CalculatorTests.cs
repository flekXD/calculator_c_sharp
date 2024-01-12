using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Calculator;

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
        }

        [TestMethod]
        public void EvaluateExpression_Addition_Success()
        {
            // Arrange
            string expression = "10 + 20";
            double expected = 30;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001); // Adding tolerance for floating-point numbers
        }

        [TestMethod]
        public void EvaluateExpression_Subtraction_Success()
        {
            // Arrange
            string expression = "20 - 10";
            double expected = 10;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void EvaluateExpression_Multiplication_Success()
        {
            // Arrange
            string expression = "20 * 10";
            double expected = 200;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void EvaluateExpression_Division_Success()
        {
            // Arrange
            string expression = "20 / 10";
            double expected = 2;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void EvaluateExpression_InvalidExpression0_ReturnsNaN()
        {
            // Arrange
            string expression = "10 +"; 
            double expected = double.NaN;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void EvaluateExpression_InvalidExpression1_ReturnsNaN()
        {
            // Arrange
            string expression = "- ( 10 + 2 )";
            double expected = double.NaN;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void EvaluateExpression_InvalidExpression2_ReturnsNaN()
        {
            // Arrange
            string expression = "-( 10 + 2 )";
            double expected = double.NaN;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void EvaluateExpression_DivisionByZero_ReturnsNaN()
        {
            // Arrange
            string expression = "10 / 0"; 
            double expected = double.NaN;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void EvaluateExpression_WorkWithBrackets0_ReturnsNaN()
        {
            // Arrange
            string expression = "( 2 + 2 ) / 2"; 
            double expected = 2;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void EvaluateExpression_WorkWithBrackets1_ReturnsNaN()
        {
            // Arrange
            string expression = "( 2 + 2 ) * ( 8 * 9 ) / 2"; 
            double expected = 144;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void EvaluateExpression_2plus2multyply2_ReturnsNaN()
        {
            // Arrange
            string expression = "2 + 2 * 2"; 
            double expected = 6;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void EvaluateExpression_2plus2InBrecktsMultyply2_ReturnsNaN()
        {
            // Arrange
            string expression = "( 2 + 2 ) * 2"; 
            double expected = 8;

            // Act
            double actual = calculator.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
