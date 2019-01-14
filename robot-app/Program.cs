using System;

namespace robot_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            var boundary = new Boundary();
            Console.WriteLine("Hello World!");
        }

        static bool CheckBoundary(Robot current)
        {
            var boundary = new Boundary();
            return current.X < boundary.MaxX && current.Y < boundary.MaxY;
        }
    }
}
