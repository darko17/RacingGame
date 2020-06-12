
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RacingGame
{
    public class Line
    {
        public Rectangle line;
        public int y;

        public Line(int y)
        {
            this.y = y;
            line = new Rectangle(220, y, 4, 150);
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.White);
            Brush b = new SolidBrush(Color.White);
            g.DrawRectangle(p, line);
            g.FillRectangle(b, line);
            p.Dispose();
            b.Dispose();
        }

        private void RestartLine()
        {
            if (line.Y >= 600)
            {
                line.Y = -200;
            }
        }

        public void MoveLine(int moveSpeed)
        {
            RestartLine();
            line.Y += moveSpeed;
        }
    }
}
