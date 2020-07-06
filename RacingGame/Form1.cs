using RacingGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        List<Line> lines;

        List<Car> cars;

        List<Coin> coins;

        Fuel f;

        public int moveSpeed { get; set; }

        int progressBarWidth = 250;

        int fuelTemp = 0;

        public Car MyCar { get; set; }

        public Form1(int moveSpeed)
        {
            this.moveSpeed = moveSpeed;
            InitializeComponent();
            //timer1.Stop();
            initLists();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Line l in lines)
            {
                l.MoveLine(moveSpeed);
            }

            foreach(Car c in cars)
            {
                c.Drive(0, moveSpeed, 0, 0, false);
                if (c.IsHit(MyCar))
                {
                    GameOver((Convert.ToInt32(txtCoinsNumber.Text)));
                }
            }
            foreach (Coin c in coins)
            {
                c.Drive(moveSpeed,c);
                if (c.IsHit(MyCar))
                {
                    coinsUp(c);
                }
            }

            f.Drive(moveSpeed, f);
            if (f.IsHit(MyCar))
            {
                fuelUp(f);
                if ((Convert.ToInt32(txtCoinsNumber.Text)) == 10 || (Convert.ToInt32(txtCoinsNumber.Text)) == 20 || (Convert.ToInt32(txtCoinsNumber.Text)) == 30)
                    moveSpeed++;
            }

            if (fuelTemp == 7)
            {
                fuelProgressBar.Size = new System.Drawing.Size(progressBarWidth, 20);
                progressBarWidth--;

                if (fuelProgressBar.Size.Width <= 0)
                    GameOver((Convert.ToInt32(txtCoinsNumber.Text)));

                fuelTemp = 0;
            }
            fuelTemp++;


            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White, 5);
            e.Graphics.DrawLine(p, 20, 0, 20, 800);
            e.Graphics.DrawLine(p, 420, 0, 420, 800);
            foreach (Line l in lines)
            {
                l.Draw(e.Graphics);
            }
            foreach (Car c in cars)
            {
                c.Draw(e.Graphics);
                c.setImage(e);
            }
            foreach (Coin c in coins)
            {
                c.Draw(e.Graphics);
                c.setImage(e);
            }

            f.Draw(e.Graphics);
            f.setImage(e);

            MyCar.setImage(e);
            p.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MyCar.Drive(15,0,0,0);
                if (moveSpeed < 30)
                {
                    moveSpeed += 3;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                MyCar.Drive(0, 15, 0, 0);
                if (moveSpeed > 18)
                {
                    moveSpeed -= 3;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                MyCar.Drive(0, 0, 15, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                MyCar.Drive(0, 0, 0, 15);
            }
        }

        public void GameOver(int coins)
        {
            timer1.Stop();
            GameOver gameOver = new GameOver(coins, true);


            DialogResult result = gameOver.ShowDialog();

            if (result == DialogResult.OK)
            {
                gameOver.Close();
                txtCoinsNumber.Text = "0";
                fuelProgressBar.Size = new System.Drawing.Size(progressBarWidth = 250, 20);
                StartGame();
            }
            else if (result == DialogResult.Cancel)
            {
                gameOver.Close();
                Application.Exit();
            }
            moveSpeed = gameOver.gameOverSpeed;
        }

        public void StartGame()
        {
            initLists();
            timer1.Start();
        }

        public void coinsUp(Coin c)
        {
            txtCoinsNumber.Text = (Convert.ToInt32(txtCoinsNumber.Text) + 1).ToString();
            c.RestartCoins();
        }

        public void fuelUp(Fuel f)
        {
            if (progressBarWidth + 30 < 250)
            {
                fuelProgressBar.Size = new System.Drawing.Size(progressBarWidth += 30, 20);
            }
            else
                fuelProgressBar.Size = new System.Drawing.Size(progressBarWidth = 250, 20);

            f.RestartFuel();
        }

        public void initLists()
        {
            lines = new List<Line>();
            cars = new List<Car>();
            coins = new List<Coin>();
            lines.Add(new Line(0));
            lines.Add(new Line(200));
            lines.Add(new Line(400));
            lines.Add(new Line(-200));
            MyCar = new Car(new Point(50, 500), Resources.myCar);
            cars.Add(new Car(new Point(50, -100), Resources.car1));
            cars.Add(new Car(new Point(200, -340), Resources.car2));
            cars.Add(new Car(new Point(300, -600), Resources.car3));
            coins.Add(new Coin(new Point(150, -300), Resources.coin));
            f = new Fuel(new Point(350, -600), Resources.fuel);
        }

    }
}
