using Xunit;
using robot_app;
using robot_app.Command;
namespace robot_test
{
    public class CommandTest
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
        public void RotateTest()
        {
            var factory = new InputFactory();
            Assert.IsType<RotateCommand>(factory.GetCommand("Rotate"));
        }


        [Fact]
        public void ReportTest()
        {
            var factory = new InputFactory();
            Assert.IsType<ReportCommand>(factory.GetCommand("Report"));
        }
    }
}
