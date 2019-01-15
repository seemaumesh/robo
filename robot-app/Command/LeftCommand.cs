using System;
namespace robot_app.Command
{
    public class LeftCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            switch (currentRobot.Dir) {
                case Face.East:
                    currentRobot.Dir = Face.North;
                    break;
                case Face.South:
                    currentRobot.Dir = Face.East;
                    break;
                case Face.West:
                    currentRobot.Dir = Face.South;
                    break;
                case Face.North:
                    currentRobot.Dir = Face.West;
                    break;
            }
            return currentRobot;
        }
    }
}
