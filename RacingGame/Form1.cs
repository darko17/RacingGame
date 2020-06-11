﻿using RacingGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<Line> lines = new List<Line>();
        List<Car> cars = new List<Car>();
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
            MyCar = new Car(new Point(50, 500), Resources.myCar);
            cars.Add(new Car(new Point(50, -100), Resources.car1));
            cars.Add(new Car(new Point(200, -340), Resources.car2));
            cars.Add(new Car(new Point(300, -600), Resources.car3));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Line l in lines)
            {
                l.MoveLine(moveSpeed);
            }

            foreach(Car c in cars)
            {
                c.Drive(0, moveSpeed, 0, 0);
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
            foreach(Car c in cars)
            {
                c.setImage(e);
            }
            MyCar.setImage(e);

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
