using System;
using robot_app;
using robot_app.Command;
using Xunit;

namespace robot_test
{
    public class CommandTest
    {
        [Fact]
        public void EastLeftTest() {
            var currRobot = new Robot() { Dir = Face.South };
            var command = new LeftCommand();
            currRobot = command.Execute("Left", currRobot);
            Assert.Equal(Face.East, currRobot.Dir);
        }

        [Fact]
        public void EastRighttTest()
        {
            var currRobot = new Robot() { Dir = Face.South };
            var command = new RightCommand();
            currRobot= command.Execute("Right", currRobot);
            Assert.Equal(Face.West, currRobot.Dir);
        }

        [Fact]
        public void MoveValidTest() {
            var currRobot = new Robot() { X=2, Y=2, Dir = Face.South };
            var command = new MoveCommand();
            currRobot = command.Execute("Move", currRobot);
            Assert.Equal(1, currRobot.Y);
            Assert.Equal(2, currRobot.X);
        }

        [Fact]
        public void MoveInValidTest()
        {
            var currRobot = new Robot() { X = 0, Y = 0, Dir = Face.South };
            var command = new MoveCommand();
            currRobot = command.Execute("Move", currRobot);
            Assert.Equal(0, currRobot.Y);
            Assert.Equal(0, currRobot.X);
        }

        [Fact]
        public void MoveBoundaryTest()
        {
            var currRobot = new Robot() { X = 0, Y = 4, Dir = Face.North };
            var command = new MoveCommand();
            currRobot = command.Execute("Move", currRobot);
            Assert.Equal(5, currRobot.Y);
            Assert.Equal(0, currRobot.X);
        }

        [Fact]
        public void MoveInTest()
        {
            var currRobot = new Robot() { X = 3, Y = 2, Dir = Face.East };
            var command = new MoveCommand();
            currRobot = command.Execute("Move", currRobot);
            Assert.Equal(4, currRobot.X);
            Assert.Equal(2, currRobot.Y);
        }
    }
}
