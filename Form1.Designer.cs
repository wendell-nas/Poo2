namespace Poo2
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
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.Location = new Point(143, 129);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(235, 86);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "SALDO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 365);
            Controls.Add(lblSaldo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldo;
    }
}