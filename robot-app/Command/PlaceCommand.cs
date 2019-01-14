using System;
namespace robot_app.Command
{
    public class PlaceCommand : ICommand
    {
        public Robot Execute(string command, Robot currentRobot)
        {
            throw new NotImplementedException();
        }

        private bool validateInput(string command) {
            var robot = new Robot();
            
            string[] inputs = command.Split(" ");
            var valid = false;
            valid = inputs.Length == 4;
            valid = valid && int.TryParse(inputs[1], out int posX);
            valid = valid && int.TryParse(inputs[1], out int posY);
            return valid;
        }

        public Face GetDirection(string direction)
        {
            Enum.TryParse(direction, out Face dir);
            return dir;
        }
    }
}
