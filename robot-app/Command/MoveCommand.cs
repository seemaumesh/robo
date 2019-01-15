using System;
namespace robot_app.Command
{
    public class MoveCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            int posX=0, posY=0;
            switch (currentRobot.Dir) {
                case Face.South:
                    posY = currentRobot.X - 1;
                    break;
                case Face.North:
                    posY = currentRobot.Y + 1;
                    break;
                case Face.East:
                    posX = currentRobot.X + 1;
                    break;
                case Face.West:
                    posX = currentRobot.X - 1;
                    break;
                default:
                    posX = 0; posY = 0;
                    break;
            }
            if(Program.CheckBoundary(posX, posY)) {
                currentRobot.X = posX;
                currentRobot.Y = posY;
            }

            return currentRobot;
        }
    }
}
