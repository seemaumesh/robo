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
    }
}
