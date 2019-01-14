using System;
using robot_app;
using robot_app.Command;
using Xunit;

namespace robot_test
{
    public class MainTest
    {
       [Fact]
       public void CheckValidPos() {
            var robot = new Robot() { X = 3, Y = 4 };
            Assert.True(Program.CheckBoundary(robot));
       }

        [Fact]
        public void CheckInValidPos()
        {
            var robot = new Robot() { X = 66, Y = 4 };
            Assert.False(Program.CheckBoundary(robot));
        }

        [Fact]
        public void CheckInValidBoundaryPos()
        {
            var robot = new Robot() { X = 5, Y = 5 };
            Assert.False(Program.CheckBoundary(robot));
        }

        [Fact]
        public void NegativePos()
        {
            var robot = new Robot() { X = -5, Y = 5 };
            Assert.False(Program.CheckBoundary(robot));
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
