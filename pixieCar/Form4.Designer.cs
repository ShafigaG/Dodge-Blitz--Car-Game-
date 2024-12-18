namespace pixieCar
{
    partial class Form4
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
            btnRetry = new Button();
            btnBTM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(376, 73);
            label1.TabIndex = 0;
            label1.Text = "GAME OVER!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRetry
            // 
            btnRetry.FlatStyle = FlatStyle.Popup;
            btnRetry.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetry.ForeColor = Color.RosyBrown;
            btnRetry.Location = new Point(12, 125);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(137, 63);
            btnRetry.TabIndex = 2;
            btnRetry.Text = "RETRY";
            btnRetry.UseVisualStyleBackColor = true;
            btnRetry.Click += button1_Click;
            // 
            // btnBTM
            // 
            btnBTM.FlatStyle = FlatStyle.Popup;
            btnBTM.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnBTM.ForeColor = Color.OrangeRed;
            btnBTM.ImageAlign = ContentAlignment.MiddleLeft;
            btnBTM.Location = new Point(155, 125);
            btnBTM.Name = "btnBTM";
            btnBTM.Size = new Size(233, 63);
            btnBTM.TabIndex = 3;
            btnBTM.Text = "BACK TO THE MENU";
            btnBTM.UseVisualStyleBackColor = true;
            btnBTM.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(400, 200);
            Controls.Add(btnBTM);
            Controls.Add(btnRetry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnRetry;
        private Button btnBTM;
    }
}