namespace UserTicketService.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }
    }
}
