using System.Configuration;
namespace robot_app
{
    public class Boundary
    {
        public Boundary() {
            this.MaxX = int.Parse(ConfigurationManager.AppSettings.Get("MaxX"));
            this.MaxY = int.Parse(ConfigurationManager.AppSettings.Get("MaxY"));
        }
        public int MaxX { get; }
       public int MaxY { get; }
    }
}
