using System;
using robot_app.Command;
namespace robot_app
{
    public class InputFactory
    {
       public ICommand GetCommand(string command)
        {
            string firstInstance = command?.Split(" ")[0];

            switch (firstInstance) {
                case "Place":
                    return new PlaceCommand();
                case "Rotate":
                    return new RotateCommand();
                case "Move":
                    return new MoveCommand();
                case "Report":
                    return new ReportCommand();
                default:
                    return new InvalidCommand();
            }
        }
    }
}
