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
                var command = new InputFactory().GetCommand(line);
                robot = command.Execute(line, robot);
                if(line == "Report") {
                    Console.WriteLine($"{robot.X}, {robot.Y} {robot.Dir}");
                    break;
                }
            }
        }

        public static bool CheckBoundary(int posX, int posY)
        {
            var boundary = new Boundary();
            return posX <= boundary.MaxX && posY <= boundary.MaxY 
                            && posX >= 0 && posY>=0;
        }

        public static bool CheckValidCommand(ICommand command, Robot current) 
        =>  (command.GetType() == typeof(PlaceCommand) && !current.Placed) || current.Placed;


    }
}
