using System;
using robot_app;
using robot_app.Command;
using Xunit;

namespace robot_test
{
    public class MainTest
    {
        [Fact]
        public void CheckValidPos()
        {

            Assert.True(Program.CheckBoundary(3, 4));
        }

        [Fact]
        public void CheckInValidPos()
        {
            Assert.False(Program.CheckBoundary(66, 4));
        }

        [Fact]
        public void CheckInValidBoundaryPos()
        {
            Assert.True(Program.CheckBoundary(5, 5));
        }

        [Fact]
        public void NegativePos()
        {
            Assert.False(Program.CheckBoundary(-5, 5));
        }

        [Fact]
        public void CheckPlaces()
        {
            var command = new PlaceCommand();
            var robot = new Robot() { Placed = false };
            Assert.True(Program.CheckValidCommand(command, robot));
        }

        [Fact]
        public void CheckPlacedNPlace()
        {
            var command = new PlaceCommand();
            var robot = new Robot() { Placed = true };
            Assert.True(Program.CheckValidCommand(command, robot));
        }

        [Fact]
        public void CheckNotPlaced()
        {
            var command = new LeftCommand();
            var robot = new Robot() { Placed = false };
            Assert.False(Program.CheckValidCommand(command, robot));
        }


    }
}
