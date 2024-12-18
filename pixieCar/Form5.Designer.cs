namespace pixieCar
{
    partial class Form5
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
            btnScoreBoardClose = new Button();
            lblScoreboard = new Label();
            dataGridView1 = new DataGridView();
            score = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnScoreBoardClose
            // 
            btnScoreBoardClose.FlatStyle = FlatStyle.Popup;
            btnScoreBoardClose.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnScoreBoardClose.ForeColor = Color.OrangeRed;
            btnScoreBoardClose.Location = new Point(492, 12);
            btnScoreBoardClose.Name = "btnScoreBoardClose";
            btnScoreBoardClose.Size = new Size(70, 70);
            btnScoreBoardClose.TabIndex = 0;
            btnScoreBoardClose.Text = "X";
            btnScoreBoardClose.UseVisualStyleBackColor = true;
            btnScoreBoardClose.Click += btnScoreBoardClose_Click;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreboard.ForeColor = Color.White;
            lblScoreboard.Location = new Point(12, 12);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(455, 70);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scoreboard";
            lblScoreboard.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { score, date });
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(550, 328);
            dataGridView1.TabIndex = 2;
            // 
            // score
            // 
            score.HeaderText = "Score";
            score.MinimumWidth = 6;
            score.Name = "score";
            score.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(582, 453);
            Controls.Add(dataGridView1);
            Controls.Add(lblScoreboard);
            Controls.Add(btnScoreBoardClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnScoreBoardClose;
        private Label lblScoreboard;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn score;
        private DataGridViewTextBoxColumn date;
    }
}