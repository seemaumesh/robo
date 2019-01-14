using System;
using robot_app.Command;

namespace robot_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            while (true) {
                Console.WriteLine("Input command");
                var line = Console.ReadLine();
                Console.WriteLine(line);
                if(line == "exit") {
                    break;
                }
            }
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
