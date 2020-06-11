
using System.Drawing;

namespace RacingGame
{
    public class Car
    {
        public Point Location { get; set; }
        public int Delete { get; set; }

        public Car()
        {
            Location = new Point(50,500);
        }

        public void Drive(int up, int down, int left, int rigth)
        {
            if (Location.X + rigth <= 340 && Location.X - left >= 0 && Location.Y + down <= 500 && Location.Y - up >= 20)
            {
                Location = new Point(Location.X + rigth - left, Location.Y - up + down);
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Transparent);
            g.FillRectangle(b, Location.X, Location.Y, 10, 10);
            b.Dispose();
        }
    }
}
