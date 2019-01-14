using System;
namespace robot_app.Command
{
    public class RightCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            currentRobot.Dir = currentRobot.Dir + 1;
            return currentRobot;
        }
    }
}
