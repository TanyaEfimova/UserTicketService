using Xunit;
using NUnit.Framework;
using System;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Xunit.Assert.Equal(8, calculator.Multiplication(2, 4));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            NUnit.Framework.Assert.That(calculator.Subtraction(2, 4) == -2);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            NUnit.Framework.Assert.That(calculator.Division(2, 4) == 0);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();

            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
        }
    }
}
