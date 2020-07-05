using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public class Fuel
    {
        public Point Location { get; set; }

        private Image FuelImage { get; set; }

        private static readonly Random random = new Random();

        Rectangle fuel;

        public Fuel(Point p, Bitmap image)
        {
            Location = p;
            FuelImage = image;
            fuel = new Rectangle(Location.X, Location.Y, 36, 90);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Transparent);
            g.FillRectangle(b, fuel.Location.X, fuel.Location.Y, 50, 100);
            b.Dispose();
        }

        public void setImage(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(FuelImage, fuel.Location);
        }

        public void Drive(int moveSpeed, Fuel c)
        {

            fuel.Location = new Point(fuel.Location.X, fuel.Location.Y + moveSpeed);
            if (fuel.Location.Y >= 600)
            {
                RestartFuel();
            }

        }

        public void RestartFuel()
        {
            int randomNum3 = random.Next(0, 100);
            if (randomNum3 < 33)
            {
                fuel.Location = new Point(random.Next(0, 90), -200 - random.Next(0, 300));
            }
            else if (randomNum3 > 34 && randomNum3 < 66)
            {
                fuel.Location = new Point(random.Next(105, 200), -250 - random.Next(0, 300));
            }
            else
            {
                fuel.Location = new Point(random.Next(215, 330), -300 - random.Next(0, 300));
            }
        }

        public bool IsHit(Car MyCar)
        {
            return MyCar.car.IntersectsWith(fuel);
        }


    }
}
