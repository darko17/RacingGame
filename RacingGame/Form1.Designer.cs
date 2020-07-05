namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCoins = new System.Windows.Forms.Label();
            this.txtCoinsNumber = new System.Windows.Forms.Label();
            this.fuelProgressBar = new System.Windows.Forms.PictureBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.startGameToolStripMenuItem.Text = "Start Game";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCoins
            // 
            this.txtCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoins.Location = new System.Drawing.Point(432, 31);
            this.txtCoins.Name = "txtCoins";
            this.txtCoins.Size = new System.Drawing.Size(82, 28);
            this.txtCoins.TabIndex = 2;
            this.txtCoins.Text = "Coins:";
            // 
            // txtCoinsNumber
            // 
            this.txtCoinsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoinsNumber.Location = new System.Drawing.Point(510, 33);
            this.txtCoinsNumber.Name = "txtCoinsNumber";
            this.txtCoinsNumber.Size = new System.Drawing.Size(70, 26);
            this.txtCoinsNumber.TabIndex = 3;
            this.txtCoinsNumber.Text = "0";
            // 
            // fuelProgressBar
            // 
            this.fuelProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fuelProgressBar.Location = new System.Drawing.Point(86, 31);
            this.fuelProgressBar.Name = "fuelProgressBar";
            this.fuelProgressBar.Size = new System.Drawing.Size(250, 20);
            this.fuelProgressBar.TabIndex = 4;
            this.fuelProgressBar.TabStop = false;
            // 
            // lblFuel
            // 
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(12, 31);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(68, 28);
            this.lblFuel.TabIndex = 5;
            this.lblFuel.Text = "Fuel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(580, 748);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.fuelProgressBar);
            this.Controls.Add(this.txtCoinsNumber);
            this.Controls.Add(this.txtCoins);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form1";
            this.Text = "RacingGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelProgressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtCoins;
        private System.Windows.Forms.Label txtCoinsNumber;
        private System.Windows.Forms.PictureBox fuelProgressBar;
        private System.Windows.Forms.Label lblFuel;
    }
}

