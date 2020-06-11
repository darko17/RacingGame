using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.White, 5);
        Line l1;
        Line l2;
        Line l3;
        Line l4;
        int moveSpeed = 15;
        float moveLineDown = 200;
        public Form1()
        {
            InitializeComponent();
            l1 = new Line(0);
            l2 = new Line(200);
            l3 = new Line(400);
            l4 = new Line(-200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l1.line.Y += moveSpeed;
            l2.line.Y += moveSpeed;
            l3.line.Y += moveSpeed;
            l4.line.Y += moveSpeed;
            if (l3.line.Y >= 600)
            {
                l3.line.Y = -200;
            }
            if (l2.line.Y >= 600)
            {
                l2.line.Y = -200;
            }
            if (l1.line.Y >= 600)
            {
                l1.line.Y = -200;
            }
            if (l4.line.Y >= 600)
            {
                l4.line.Y = -200;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen p = new Pen(Color.White, 5);
            g.DrawLine(p, 20, 0, 20, 800);
            g.DrawLine(p, 420, 0, 420, 800);
            l1.Draw(g);
            l2.Draw(g);
            l3.Draw(g);
            l4.Draw(g);
            g.Dispose();
        }
    }
}
