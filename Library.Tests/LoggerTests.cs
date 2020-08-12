using NUnit.Framework;

namespace Library.Tests
{
    public class LoggerTests
    {
        [Test]
        public void ShareMessage_ShouldNotReturnAnException()
            =>Assert.DoesNotThrow(() => new Logger().ShareMessage("Test"));
    }
}