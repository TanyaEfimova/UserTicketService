using Xunit;
using NUnit.Framework;

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
    }
}
