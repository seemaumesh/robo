using System;
namespace robot_app.Command
{
    public class RightCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            switch (currentRobot.Dir)
            {
                case Face.East:
                    currentRobot.Dir = Face.South;
                    break;
                case Face.South:
                    currentRobot.Dir = Face.West;
                    break;
                case Face.West:
                    currentRobot.Dir = Face.North;
                    break;
                case Face.North:
                    currentRobot.Dir = Face.East;
                    break;
            }
            return currentRobot;
        }
    }
}
