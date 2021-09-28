using NUnit.Framework;
using System;

namespace Calculator.Test.Unit
{
    public class CalculatorUnitTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(2, 3, 5)]
        public void Add_TwoPositive_ExpectedResultIsCorrect(double add1, double add2, double result)
        {
            Assert.That(uut.Add(add1, add2), Is.EqualTo(result));
        }

        [TestCase(-2, -3, -5)]
        public void Add_TwoNegative_ExpectedResultIsCorrect(double add1, double add2, double result)
        {
            Assert.That(uut.Add(add1, add2), Is.EqualTo(result));
        }

        [TestCase(2, -3, -1)]
        public void Add_OnePositiveOneNegative_ExpectedResultIsCorrect(double add1, double add2, double result)
        {
            Assert.That(uut.Add(add1, add2), Is.EqualTo(result));
        }

        [TestCase(2, 3, -1)]
        public void Subtract_TwoPositive_ExpectedResultIsCorrect(double sub1, double sub2, double result)
        {
            Assert.That(uut.Subtract(sub1, sub2), Is.EqualTo(result));
        }

        [TestCase(-2, -3, 1)]
        public void Subtract_TwoNegative_ExpectedResultIsCorrect(double sub1, double sub2, double result)
        {
            Assert.That(uut.Subtract(sub1, sub2), Is.EqualTo(result));
        }

        [TestCase(2, -3, 5)]
        public void Subtract_OnePositiveOneNegative_ExpectedResultIsCorrect(double sub1, double sub2, double result)
        {
            Assert.That(uut.Subtract(sub1, sub2), Is.EqualTo(result));
        }

        [TestCase(2, 3, 6)]
        public void Multiply_TwoPositive_ExpectedResultIsCorrect(double mul1, double mul2, double result)
        {
            Assert.That(uut.Multiply(mul1, mul2), Is.EqualTo(result));
        }
        
        [TestCase(-2, -3, 6)]
        public void Multiply_TwoNegative_ExpectedResultIsCorrect(double mul1, double mul2, double result)
        {
            Assert.That(uut.Multiply(mul1, mul2), Is.EqualTo(result));
        }

        [TestCase(-2, 3, -6)]
        public void Multiply_OnePositiveOneNegative_ExpectedResultIsCorrect(double mul1, double mul2, double result)
        {
            Assert.That(uut.Multiply(mul1, mul2), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        public void Power_TwoPositive_ExpectedResultIsCorrect(double pow1, double pow2, double result)
        {
            Assert.That(uut.Power(pow1, pow2), Is.EqualTo(result));
        }

        [TestCase(-2, -3, -0.125)]
        public void Power_TwoNegative_ExpectedResultIsCorrect(double pow1, double pow2, double result)
        {
            Assert.That(uut.Power(pow1, pow2), Is.EqualTo(result));
        }

        [TestCase(-2, 3, -8)]
        public void Power_OnePositiveOneNegative_ExpectedResultIsCorrect(double pow1, double pow2, double result)
        {
            Assert.That(uut.Power(pow1, pow2), Is.EqualTo(result));
        }

        [TestCase(5, 0)]
        public void Divide_DivisorIsZero_ExceptionIsThrown(double div1, double div2)
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(div1, div2));
        }

        [TestCase(0, 5, 0)]
        public void Divide_DividendIsZero_ExpectedResultIsCorrect(double div1, double div2, double result)
        {
            Assert.That(uut.Divide(div1, div2), Is.EqualTo(result));
        }

        [TestCase(5, 5, 1)]
        public void Divide_TwoPositive_ExpectedResultIsCorrect(double div1, double div2, double result)
        {
            Assert.That(uut.Divide(div1, div2), Is.EqualTo(result));
        }

        [TestCase(5, -5, -1)]
        public void Divide_DivisorIsNegative_ExpectedResultIsCorrect(double div1, double div2, double result)
        {
            Assert.That(uut.Divide(div1, div2), Is.EqualTo(result));
        }

        [TestCase(-5, -5, 1)]
        public void Divide_TwoNegative_ExpectedResultIsCorrect(double div1, double div2, double result)
        {
            Assert.That(uut.Divide(div1, div2), Is.EqualTo(result));
        }

        [TestCase(-2, -4, -6)]
        [TestCase(2, 10.4, 12.4)]
        [TestCase(0.1, 0.9, 1)]
        public void AddTwoNumbers_CheckAccumulator_AccumulatorIsRes(double add1, double add2, double res)
        {
            uut.Add(add1, add2);
            Assert.That(uut._Accumulator, Is.EqualTo(res));
        }
        [TestCase(2, 4, 0.5)]
        [TestCase(25, 3, 8.333)]
        public void Divide_TwoNumbers_AccumulatorIsRes(double div1, double div2, double res)
        {
            uut.Divide(div1, div2);
            Assert.That(uut._Accumulator, Is.EqualTo(res).Within(0.05));
        }
    }
}