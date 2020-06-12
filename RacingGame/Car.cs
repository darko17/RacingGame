
using RacingGame.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public class Car
    {
        public Point Location { get; set; }

        private Image CarImage { get; set; }

        private static readonly Random random = new Random();

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
            if (!isMyCar)
            {
                Location = new Point(Location.X, Location.Y + down);
                if (Location.Y >= 600)
                {
                    RestartCars();
                }
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

        private void RestartCars()
        {
            int randomNum3 = random.Next(0, 100);
            if (randomNum3 < 33)
            {
                Location = new Point(random.Next(0, 90), -200 - random.Next(0, 300));
            }
            else if (randomNum3 > 34 && randomNum3 < 66)
            {
                Location = new Point(random.Next(105, 200), -250 - random.Next(0, 300));
            }
            else
            {
                Location = new Point(random.Next(215, 330), -300 - random.Next(0, 300));
            }
        }
    }
}
