using System;
using robot_app;
using robot_app.Command;
using Xunit;
namespace robot_test
{
    public class PlaceCommandTest
    {
        [Fact]
        public void GetNorthDir()
        {
            var dir = "North";
            Assert.Equal(Face.North, new PlaceCommand().GetDirection(dir));
        }

        [Fact]
        public void GetSouthDir()
        {
            var dir = "South";
            Assert.Equal(Face.South, new PlaceCommand().GetDirection(dir));
        }

        [Fact]
        public void GetSEastDir()
        {
            var dir = "East";
            Assert.Equal(Face.East, new PlaceCommand().GetDirection(dir));
        }

        [Fact]
        public void GetWestDir()
        {
            var dir = "West";
            Assert.Equal(Face.West, new PlaceCommand().GetDirection(dir));
        }

        [Fact]
        public void GetInvDir()
        {
            var dir = "ABC";
            Assert.Equal(Face.South, new PlaceCommand().GetDirection(dir));
        }

        [Fact]
        public void PlaceTest()
        {
            var currRobot = new Robot();
            var place = new PlaceCommand();
            currRobot = place.Execute("Place 4,4, South", currRobot);
            var expected = new Robot() { Dir = Face.South, X = 4, Y = 4 };
            Assert.Equal(expected.Dir, currRobot.Dir);
            Assert.Equal(expected.X, currRobot.X);
            Assert.Equal(expected.Y, currRobot.Y);
        }

        [Fact]
        public void PlaceBoundaryTest()
        {
            var currRobot = new Robot();
            var place = new PlaceCommand();
            currRobot = place.Execute("Place 0,5, East", currRobot);
            var expected = new Robot() { Dir = Face.East, X = 0, Y = 5 };
            Assert.Equal(expected.Dir, currRobot.Dir);
            Assert.Equal(expected.X, currRobot.X);
            Assert.Equal(expected.Y, currRobot.Y);
        }

        [Fact]
        public void PlaceBoundaryNegTest()
        {
            var currRobot = new Robot();
            var place = new PlaceCommand();
            currRobot = place.Execute("Place -2,7, East", currRobot);
            var expected = new Robot() { Dir = Face.South, X = 0, Y = 0 };
            Assert.Equal(expected.Dir, currRobot.Dir);
            Assert.Equal(expected.X, currRobot.X);
            Assert.Equal(expected.Y, currRobot.Y);
        }
    }
}
