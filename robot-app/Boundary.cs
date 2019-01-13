using Microsoft.Extensions.Configuration;

namespace robot_app
{
    public class Boundary
    {
        public Boundary() {
            var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
            MaxX = int.Parse(config["MaxX"]);
           MaxY = int.Parse(config["MaxX"]);
        }
        public int MaxX { get; }
       public int MaxY { get; }
    }
}
