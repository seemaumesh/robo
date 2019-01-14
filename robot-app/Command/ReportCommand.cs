using System;
namespace robot_app.Command
{
    public class ReportCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            currentRobot.Report = true;
            return currentRobot;
        }
    }
}
