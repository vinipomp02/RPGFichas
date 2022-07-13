namespace RPGFichas
{
    partial class Menu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpFichas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFicha = new System.Windows.Forms.Button();
            this.flpFichas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Euphorigenic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(562, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(829, 112);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Escolha seu Personagem";
            // 
            // flpFichas
            // 
            this.flpFichas.Controls.Add(this.btnAddFicha);
            this.flpFichas.Location = new System.Drawing.Point(304, 126);
            this.flpFichas.Name = "flpFichas";
            this.flpFichas.Size = new System.Drawing.Size(1231, 903);
            this.flpFichas.TabIndex = 4;
            // 
            // btnAddFicha
            // 
            this.btnAddFicha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddFicha.Font = new System.Drawing.Font("Segoe UI", 78F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFicha.Location = new System.Drawing.Point(3, 3);
            this.btnAddFicha.Name = "btnAddFicha";
            this.btnAddFicha.Size = new System.Drawing.Size(283, 433);
            this.btnAddFicha.TabIndex = 0;
            this.btnAddFicha.Text = "+";
            this.btnAddFicha.UseVisualStyleBackColor = false;
            this.btnAddFicha.Click += new System.EventHandler(this.btnAddFicha_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.flpFichas);
            this.Controls.Add(this.lblTitle);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flpFichas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private FlowLayoutPanel flpFichas;
        private Button btnAddFicha;
    }
}