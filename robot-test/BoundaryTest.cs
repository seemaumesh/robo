using Xunit;
using robot_app;

namespace robot_test
{
    public class BoundaryTest
    {
        [Fact]
        public void MaxXTest() {
           
            var boundary = new Boundary();
            Assert.Equal(5, boundary.MaxX);
        }
    }
}
