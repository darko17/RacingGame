
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RacingGame
{
    public class Line
    {
        Pen p = new Pen(Color.White);
        Brush b = new SolidBrush(Color.White);
        public Rectangle line;
        public int y;

        public Line(int y)
        {
            this.y = y;
            line = new Rectangle(220, y, 4, 150);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(p, line);
            g.FillRectangle(b, line);
        }
    }
}
