using CoverletDemo.Core;
using Xunit;

namespace CoverletDemo.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 6;
            int b = 2;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            int a = 6;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void SquareRoot_ShouldReturnCorrectValue()
        {
            // Arrange
            int a = 9;

            // Act
            double result = _calculator.SquareRoot(a);

            // Assert
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void SquareRoot_NegativeNumber_ShouldThrowException()
        {
            // Arrange
            int a = -9;

            // Act & Assert
            Assert.Throws<ArithmeticException>(() => _calculator.SquareRoot(a));
        }

        [Fact]
        public void Power_ShouldReturnCorrectValue()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            double result = _calculator.Power(a, b);

            // Assert
            Assert.Equal(8.0, result);
        }


        [Fact]
        public void Log_WithBase_ShouldReturnCorrectValue()
        {
            // Arrange
            int a = 16;
            double newBase = 4;

            // Act
            double result = _calculator.Log(a, newBase);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void Log10_ShouldReturnCorrectValue()
        {
            // Arrange
            int a = 100;

            // Act
            double result = _calculator.Log10(a);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void Abs_ShouldReturnPositiveValue()
        {
            // Arrange
            int a = -5;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Abs_ShouldReturnZero()
        {
            // Arrange
            int a = 0;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal(0.0, result);
        }

        [Fact]
        public void Abs_ShouldReturnPositiveValueForPositiveInput()
        {
            // Arrange
            int a = 5;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Abs_ShouldReturnPositiveValueForNegativeInput()
        {
            // Arrange
            int a = -5;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Abs_ShouldReturnPositiveValueForMaxValue()
        {
            // Arrange
            int a = int.MaxValue;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal((double)int.MaxValue, result);
        }



        [Fact]
        public void Abs_ShouldReturnPositiveValueForMaxValueMinusOne()
        {
            // Arrange
            int a = int.MaxValue - 1;

            // Act
            double result = _calculator.Abs(a);

            // Assert
            Assert.Equal((double)int.MaxValue - 1, result);
        }



    }
}