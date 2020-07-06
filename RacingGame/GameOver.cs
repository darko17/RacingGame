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
    public partial class GameOver : Form
    {
        private int coins;
        private bool flag;
        public GameOver(int coins)
        {
            InitializeComponent();
            this.coins = coins;
            lblPoints.Text = "Colected coins: " + coins;
        }

        public GameOver(int coins, bool flag)
        {
            InitializeComponent();
            this.coins = coins;
            lblPoints.Text = "Colected coins: " + coins;
            this.flag = flag;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {

            if (ddlLevel.SelectedIndex == 0)
            {
                if (!flag)
                {

                    Form1 form = new Form1(4);

                    DialogResult result = form.ShowDialog();

                    DialogResult = DialogResult.OK;

                    form.moveSpeed = 4;
                }

                else
                {
                    DialogResult = DialogResult.OK;

                }

            }

            else if (ddlLevel.SelectedIndex == 1)
            {
                if (!flag)
                {

                    Form1 form = new Form1(5);

                    DialogResult result = form.ShowDialog();

                    DialogResult = DialogResult.OK;

                    form.moveSpeed = 5;


                }

                else
                {
                    DialogResult = DialogResult.OK;

                }


            }

            else if (ddlLevel.SelectedIndex == 2)
            {
                if (!flag)
                {

                    Form1 form = new Form1(7);

                    DialogResult result = form.ShowDialog();

                    DialogResult = DialogResult.OK;

                    form.moveSpeed = 6;


                }

                else
                {
                    DialogResult = DialogResult.OK;

                    //moveSpeed = 7;
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
