using System.Diagnostics.CodeAnalysis;

namespace CoverletDemo.Core
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (double)a / b;
        }

        public double SquareRoot(int a)
        {
            if (a < 0)
            {
                throw new ArithmeticException("Cannot calculate square root of a negative number");
            }
            return System.Math.Sqrt(a);
        }

        public double Power(int a, int b)
        {
            return System.Math.Pow(a, b);
        }

        [ExcludeFromCodeCoverage]
        public double Log(int a)
        {
            if (a <= 0)
            {
                throw new ArithmeticException("Cannot calculate logarithm of a non-positive number");
            }
            return System.Math.Log(a);
        }

        [ExcludeFromCodeCoverage]
        public double Log(int a, double newBase)
        {
            if (a <= 0 || newBase <= 0)
            {
                throw new ArithmeticException("Cannot calculate logarithm of a non-positive number or with a non-positive base");
            }
            return System.Math.Log(a, newBase);
        }

        [ExcludeFromCodeCoverage]
        public double Log10(int a)
        {
            if (a <= 0)
            {
                throw new ArithmeticException("Cannot calculate logarithm of a non-positive number");
            }
            return System.Math.Log10(a);
        }

        public double Abs(int a)
        {
            return System.Math.Abs(a);
        }
    }
}