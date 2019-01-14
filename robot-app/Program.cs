using System;
using robot_app.Command;

namespace robot_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            var boundary = new Boundary();
            Console.WriteLine("Hello World!");
        }

        public static bool CheckBoundary(Robot current)
        {
            var boundary = new Boundary();
            return current.X < boundary.MaxX && current.Y < boundary.MaxY 
                            && current.X >= 0 && current.Y>=0;
        }

        public static bool CheckValidCommand(ICommand command, Robot current) 
        =>  (command.GetType() == typeof(PlaceCommand) && !current.Placed) || current.Placed;
    }
}
