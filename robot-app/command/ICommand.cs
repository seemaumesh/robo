using System;
namespace robot_app.Command
{
    public interface ICommand
    {
        Robot Execute(string command, Robot currentRobot);
    }
}
