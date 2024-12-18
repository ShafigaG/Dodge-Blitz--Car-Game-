namespace pixieCar
{
    partial class Form3
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
            label1 = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(435, 67);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to quit the game? ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // buttonYes
            // 
            buttonYes.BackColor = Color.Transparent;
            buttonYes.FlatStyle = FlatStyle.Popup;
            buttonYes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonYes.ForeColor = Color.Silver;
            buttonYes.Location = new Point(12, 91);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(208, 53);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "YES";
            buttonYes.UseVisualStyleBackColor = false;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.BackColor = Color.Transparent;
            buttonNo.FlatStyle = FlatStyle.Popup;
            buttonNo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNo.ForeColor = Color.FromArgb(64, 64, 64);
            buttonNo.Location = new Point(240, 91);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(207, 53);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "NO";
            buttonNo.UseVisualStyleBackColor = false;
            buttonNo.Click += buttonNo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(460, 156);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonYes;
        private Button buttonNo;
    }
}