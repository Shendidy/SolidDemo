using NUnit.Framework;

namespace Library.Tests
{
    public class LoggerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShareMessage_ShouldNotReturnAnException()
        {
            Assert.DoesNotThrow(() => new Logger().ShareMessage(""));
        }
    }
}