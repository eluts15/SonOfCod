using SonOfCod2.Models;
using Xunit;

namespace SonOfCod.Tests.ModelTests
{
    public class SubscriberTest
    {
        [Fact]
        public void Get_Email_Test()
        {
            Subscriber subscriber = new Subscriber("eluts15@gmail.com");

            string result = subscriber.Email;

            Assert.Equal("eluts15@gmail.com", result);
        }
    }
}
