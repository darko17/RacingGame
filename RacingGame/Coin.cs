using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public class Coin
    {
        public Point Location { get; set; }

        private Image CoinImage { get; set; }

        private static readonly Random random = new Random();

        Rectangle coin;

        public Coin(Point p, Bitmap image)
        {
            Location = p;
            CoinImage = image;
            coin = new Rectangle(Location.X, Location.Y, 36, 90);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Transparent);
            g.FillRectangle(b, coin.Location.X, coin.Location.Y, 50, 100);
            b.Dispose();
        }

        public void setImage(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(CoinImage, coin.Location);
        }

        public void Drive(int moveSpeed, Coin c)
        {

            coin.Location = new Point(coin.Location.X, coin.Location.Y + moveSpeed);
            if (coin.Location.Y >= 600)
            {
                RestartCoins();
            }

        }

        public void RestartCoins()
        {
            int randomNum3 = random.Next(0, 100);
            if (randomNum3 < 33)
            {
                coin.Location = new Point(random.Next(0, 90), -200 - random.Next(0, 300));
            }
            else if (randomNum3 > 34 && randomNum3 < 66)
            {
                coin.Location = new Point(random.Next(105, 200), -250 - random.Next(0, 300));
            }
            else
            {
                coin.Location = new Point(random.Next(215, 330), -300 - random.Next(0, 300));
            }
        }

        public bool IsHit(Car MyCar)
        {
            return MyCar.car.IntersectsWith(coin);
        }

    }
}
