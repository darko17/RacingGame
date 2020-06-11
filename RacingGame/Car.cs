
using RacingGame.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public class Car
    {
        public Point Location { get; set; }

        private Image CarImage { get; set; }
        public int Delete { get; set; }

        public Car(Point p, Bitmap image)
        {
            Location = p;
            CarImage = image;
        }

        public void Drive(int up, int down, int left, int rigth, bool isMyCar = true)
        {
            if (Location.X + rigth <= 340 && Location.X - left >= 0 && Location.Y + down <= 500 && Location.Y - up >= 20 && isMyCar)
            {
                Location = new Point(Location.X + rigth - left, Location.Y - up + down);
            }
            else
            {
                Location = new Point(Location.X, Location.Y + down);
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Transparent);
            g.FillRectangle(b, Location.X, Location.Y, 10, 10);
            b.Dispose();
        }

        public void setImage(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(CarImage, Location);
        }
    }
}
