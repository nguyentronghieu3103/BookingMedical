namespace BookingMedical.GUI.Forms.Common
{
    partial class FormLogin
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
            pnLeft = new Panel();
            pnRight = new Panel();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.DeepSkyBlue;
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(400, 560);
            pnLeft.TabIndex = 0;
            // 
            // pnRight
            // 
            pnRight.BackColor = Color.White;
            pnRight.Dock = DockStyle.Fill;
            pnRight.Location = new Point(400, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(500, 560);
            pnRight.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLeft;
        private Panel pnRight;
    }
}