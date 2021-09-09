using System;

namespace Calculator
{
    public class Calculator
    {
        public double _Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            return _Accumulator = a + b;
        }
        public double Subtract(double a, double b)
        {
            return _Accumulator = a - b;
        }
        public double Multiply(double a, double b)
        {
            return _Accumulator = a * b;
        }
        public double Power(double x, double exp)
        {
            return _Accumulator = Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return _Accumulator = dividend / divisor;
        }
    }
}
