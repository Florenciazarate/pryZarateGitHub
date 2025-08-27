namespace pryZarateGitHub
{
    partial class frmGitHub
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
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            txtHambre = new TextBox();
            lblHambre = new Label();
            btnYoTambien = new Button();
            SuspendLayout();
            // 
            // txtHambre
            // 
            txtHambre.Location = new Point(286, 109);
            txtHambre.Name = "txtHambre";
            txtHambre.Size = new Size(100, 23);
            txtHambre.TabIndex = 1;
            // 
            // lblHambre
            // 
            lblHambre.AutoSize = true;
            lblHambre.Location = new Point(265, 91);
            lblHambre.Name = "lblHambre";
            lblHambre.Size = new Size(143, 15);
            lblHambre.TabIndex = 2;
            lblHambre.Text = "TENGO MUCHA HAMBRE";
            // 
            // btnYoTambien
            // 
            btnYoTambien.Location = new Point(298, 138);
            btnYoTambien.Name = "btnYoTambien";
            btnYoTambien.Size = new Size(75, 23);
            btnYoTambien.TabIndex = 3;
            btnYoTambien.Text = "Yo tambien";
            btnYoTambien.UseVisualStyleBackColor = true;
            // 
            // frmGitHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYoTambien);
            Controls.Add(lblHambre);
            Controls.Add(txtHambre);
            Name = "frmGitHub";
            Load += frmGitHub_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private TextBox txtHambre;
        private Label lblHambre;
        private Button btnYoTambien;
    }
}