using System;
namespace robot_app.Command
{
    public class InvalidCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            return currentRobot;
        }
    }
}
