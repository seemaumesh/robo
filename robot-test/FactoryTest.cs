using Xunit;
using robot_app;
using robot_app.Command;
namespace robot_test
{
    public class FactoryTest
    {
        [Fact]
        public void PlaceTest()
        {
            var factory = new InputFactory();
            Assert.IsType<PlaceCommand>(factory.GetCommand("Place some"));
        }

        [Fact]
        public void InvalidTest()
        {
            var factory = new InputFactory();
            Assert.IsType<InvalidCommand>(factory.GetCommand("Some some"));
        }

        [Fact]
        public void LeftTest()
        {
            var factory = new InputFactory();
            Assert.IsType<LeftCommand>(factory.GetCommand("Left"));
        }

        [Fact]
        public void RightTest()
        {
            var factory = new InputFactory();
            Assert.IsType<RightCommand>(factory.GetCommand("Right"));
        }


        [Fact]
        public void ReportTest()
        {
            var factory = new InputFactory();
            Assert.IsType<ReportCommand>(factory.GetCommand("Report"));
        }
    }
}
