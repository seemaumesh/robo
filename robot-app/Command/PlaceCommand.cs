using System;
namespace robot_app.Command
{
    public class PlaceCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            var robot = new Robot();
            int posX = 0, posY = 0;
            string[] inputs = command.Split(",");

            var valid = false;
            valid = inputs.Length == 3;
            if (valid)
            {
                inputs[0] = inputs[0].Substring(inputs[0].IndexOf(' ')).Trim();
                valid = valid && int.TryParse(inputs[0], out posX);
                valid = valid && int.TryParse(inputs[1], out posY);
            }
            if (valid && Program.CheckBoundary(posX, posY))
            {
                robot.Dir = GetDirection(inputs[2]);
                robot.X = posX;
                robot.Y = posY;
            }
            return robot;
        }

        public Face GetDirection(string direction)
        {
            Enum.TryParse(direction, out Face dir);
            return dir;
        }
    }
}
