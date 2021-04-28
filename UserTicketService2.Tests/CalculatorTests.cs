namespace UserTicketService.Tests
{
    //using Xunit;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
