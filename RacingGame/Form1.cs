using RacingGame.Properties;
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
        List<Line> lines = new List<Line>();
        int moveSpeed = 15;
        public Car MyCar { get; set; }
        private Image MyCarImage { get; set; }
        public Form1()
        {
            InitializeComponent();
            lines.Add(new Line(0));
            lines.Add(new Line(200));
            lines.Add(new Line(400));
            lines.Add(new Line(-200));
            MyCar = new Car();
            MyCarImage = Resources.myCar;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Line l in lines)
            {
                l.MoveLine(moveSpeed);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen p = new Pen(Color.White, 5);
            g.DrawLine(p, 20, 0, 20, 800);
            g.DrawLine(p, 420, 0, 420, 800);
            foreach (Line l in lines)
            {
                l.Draw(g);
            }
            e.Graphics.DrawImageUnscaled(MyCarImage, MyCar.Location);
            g.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MyCar.Drive(10,0,0,0);
                if (moveSpeed < 30)
                {
                    moveSpeed += 3;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                MyCar.Drive(0, 10, 0, 0);
                if (moveSpeed > 18)
                {
                    moveSpeed -= 3;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                MyCar.Drive(0, 0, 10, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                MyCar.Drive(0, 0, 0, 10);
            }
        }
    }
}
