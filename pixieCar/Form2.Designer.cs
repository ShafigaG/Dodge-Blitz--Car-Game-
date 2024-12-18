namespace pixieCar
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            labelScore = new Label();
            explosion = new PictureBox();
            player = new PictureBox();
            ai2 = new PictureBox();
            ai1 = new PictureBox();
            roadTrack2 = new PictureBox();
            roadTrack = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ai2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ai1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelScore);
            panel1.Controls.Add(explosion);
            panel1.Controls.Add(player);
            panel1.Controls.Add(ai2);
            panel1.Controls.Add(ai1);
            panel1.Controls.Add(roadTrack2);
            panel1.Controls.Add(roadTrack);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 876);
            panel1.TabIndex = 0;
            // 
            // labelScore
            // 
            labelScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = Color.FromArgb(255, 128, 0);
            labelScore.Location = new Point(294, 0);
            labelScore.Name = "labelScore";
            labelScore.RightToLeft = RightToLeft.Yes;
            labelScore.Size = new Size(282, 48);
            labelScore.TabIndex = 10;
            labelScore.Text = "0";
            // 
            // explosion
            // 
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(109, 475);
            explosion.Name = "explosion";
            explosion.Size = new Size(70, 66);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.TabIndex = 9;
            explosion.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.CarRed;
            player.Location = new Point(272, 712);
            player.Name = "player";
            player.Size = new Size(82, 144);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 7;
            player.TabStop = false;
            // 
            // ai2
            // 
            ai2.Image = Properties.Resources.carPink;
            ai2.Location = new Point(364, 170);
            ai2.Name = "ai2";
            ai2.Size = new Size(82, 144);
            ai2.SizeMode = PictureBoxSizeMode.StretchImage;
            ai2.TabIndex = 6;
            ai2.TabStop = false;
            ai2.Tag = "carRight";
            // 
            // ai1
            // 
            ai1.Image = Properties.Resources.carGreen;
            ai1.Location = new Point(3, 196);
            ai1.Name = "ai1";
            ai1.Size = new Size(82, 144);
            ai1.SizeMode = PictureBoxSizeMode.StretchImage;
            ai1.TabIndex = 5;
            ai1.TabStop = false;
            ai1.Tag = "carLeft";
            // 
            // roadTrack2
            // 
            roadTrack2.Image = Properties.Resources.roadTrack;
            roadTrack2.Location = new Point(0, 0);
            roadTrack2.Name = "roadTrack2";
            roadTrack2.Size = new Size(576, 876);
            roadTrack2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTrack2.TabIndex = 4;
            roadTrack2.TabStop = false;
            roadTrack2.Click += roadTrack2_Click;
            // 
            // roadTrack
            // 
            roadTrack.Image = Properties.Resources.roadTrack;
            roadTrack.Location = new Point(0, -876);
            roadTrack.Name = "roadTrack";
            roadTrack.Size = new Size(576, 876);
            roadTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTrack.TabIndex = 3;
            roadTrack.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 900);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ai2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ai1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox roadTrack;
        private PictureBox roadTrack2;
        private PictureBox player;
        private PictureBox ai2;
        private PictureBox ai1;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox explosion;
        private Label labelScore;
    }
}