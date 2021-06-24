using Moq;
using Xunit;

namespace UserTicketService.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void MakeNotificationMustReturnTrue()
        {
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(v => v.Send()).Returns(true);

            var notification = new Notification(mockMailSender.Object);
            Assert.True(notification.MakeNotification());
        }
    }
}
