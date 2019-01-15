using System;
namespace robot_app.Command
{
    public class MoveCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            int posX=currentRobot.X, posY=currentRobot.Y;
            switch (currentRobot.Dir) {
                case Face.South:
                    posY = posY - 1;
                    break;
                case Face.North:
                    posY = posY + 1;
                    break;
                case Face.East:
                    posX = posX + 1;
                    break;
                case Face.West:
                    posX = posX - 1;
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
