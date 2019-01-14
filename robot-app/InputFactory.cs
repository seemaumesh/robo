using System;
using robot_app.Command;
namespace robot_app
{
    public class InputFactory
    {
       public ICommand GetCommand(string command)
        {
            string firstInstance = command?.Split(" ")[0];
            firstInstance = firstInstance.ToLower();

            switch (firstInstance) {
                case "place":
                    return new PlaceCommand();
                case "left":
                    return new LeftCommand();
                case "right":
                    return new RightCommand();
                case "move":
                    return new MoveCommand();
                case "report":
                    return new ReportCommand();
                default:
                    return new InvalidCommand();
            }
        }
    }
}
