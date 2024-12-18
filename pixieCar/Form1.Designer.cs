namespace pixieCar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPlay = new Button();
            btnAbout = new Button();
            btnMusicOnOff = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = (Image)resources.GetObject("btnPlay.BackgroundImage");
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.OrangeRed;
            btnPlay.Location = new Point(143, 428);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(300, 70);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.BackgroundImage = (Image)resources.GetObject("btnAbout.BackgroundImage");
            btnAbout.FlatStyle = FlatStyle.Popup;
            btnAbout.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.OrangeRed;
            btnAbout.Location = new Point(143, 516);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(300, 70);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "SCOREBOARD";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnMusicOnOff
            // 
            btnMusicOnOff.BackColor = Color.Transparent;
            btnMusicOnOff.BackgroundImage = (Image)resources.GetObject("btnMusicOnOff.BackgroundImage");
            btnMusicOnOff.BackgroundImageLayout = ImageLayout.Stretch;
            btnMusicOnOff.FlatStyle = FlatStyle.Popup;
            btnMusicOnOff.Location = new Point(12, 12);
            btnMusicOnOff.Name = "btnMusicOnOff";
            btnMusicOnOff.Size = new Size(59, 55);
            btnMusicOnOff.TabIndex = 3;
            btnMusicOnOff.UseVisualStyleBackColor = false;
            btnMusicOnOff.Click += button4_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(143, 607);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(300, 70);
            btnExit.TabIndex = 4;
            btnExit.Text = "QUIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Magneto", 49.8000031F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(566, 101);
            label1.TabIndex = 5;
            label1.Text = "Dodge Blitz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 900);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnMusicOnOff);
            Controls.Add(btnAbout);
            Controls.Add(btnPlay);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private Button btnPlay;
        private Button btnAbout;
        private Button btnMusicOnOff;
        private Button btnExit;
        private Label label1;
    }
}