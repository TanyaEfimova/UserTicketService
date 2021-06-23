using Xunit;

namespace UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.Equal(8, calculator.Multiplication(2, 4));
        }
    }
}
