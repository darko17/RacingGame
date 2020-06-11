
using System.Drawing;

namespace RacingGame
{
    public class Car
    {
        public Point Location { get; set; }
        public int Delete { get; set; }

        public static int drivingSpeed;

        public Car(Point p)
        {
            Location = p;
            Delete = 0;
        }

        public void Drive(int drivingSpeed)
        {
            Location = new Point(Location.X, Location.Y + drivingSpeed);
        }
    }
}
