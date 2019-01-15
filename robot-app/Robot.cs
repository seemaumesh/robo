using System;
namespace robot_app
{
    public enum Face { South=0, East=1, North=2, West=3 }

    public class Robot
    {
        public Face Dir { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Placed{ get; set; }
        public bool Report { get; set; }
    }
}
