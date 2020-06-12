
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

        private GraphicsUnit units = GraphicsUnit.Point;

        Rectangle car;

        public Car(Point p, Bitmap image)
        {
            Location = p;
            CarImage = image;
            car = new Rectangle(Location.X, Location.Y, 36, 90);
        }

        public void Drive(int up, int down, int left, int rigth, bool isMyCar = true)
        {
            if (car.Location.X + rigth <= 340 && car.Location.X - left >= 0 && car.Location.Y + down <= 500 && car.Location.Y - up >= 20 && isMyCar)
            {
                car.Location = new Point(car.Location.X + rigth - left, car.Location.Y - up + down);
            }
            if (!isMyCar)
            {
                car.Location = new Point(car.Location.X, car.Location.Y + down);
                if (car.Location.Y >= 600)
                {
                    RestartCars();
                }
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Transparent);
            g.FillRectangle(b, car.Location.X, car.Location.Y, 50, 100);
            b.Dispose();
        }

        public void setImage(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(CarImage, car.Location);
        }

        private void RestartCars()
        {
            int randomNum3 = random.Next(0, 100);
            if (randomNum3 < 33)
            {
                car.Location = new Point(random.Next(0, 90), -200 - random.Next(0, 300));
            }
            else if (randomNum3 > 34 && randomNum3 < 66)
            {
                car.Location = new Point(random.Next(105, 200), -250 - random.Next(0, 300));
            }
            else
            {
                car.Location = new Point(random.Next(215, 330), -300 - random.Next(0, 300));
            }
        }

        public bool IsHit(Car c)
        {
            return c.car.IntersectsWith(car);
        }
    }
}
