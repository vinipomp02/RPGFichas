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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBruna = new System.Windows.Forms.Button();
            this.lblBruna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Euphorigenic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(562, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(829, 112);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Escolha seu Personagem";
            // 
            // btnBruna
            // 
            this.btnBruna.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBruna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBruna.Image = ((System.Drawing.Image)(resources.GetObject("btnBruna.Image")));
            this.btnBruna.Location = new System.Drawing.Point(585, 174);
            this.btnBruna.Name = "btnBruna";
            this.btnBruna.Size = new System.Drawing.Size(160, 160);
            this.btnBruna.TabIndex = 1;
            this.btnBruna.UseVisualStyleBackColor = false;
            this.btnBruna.Click += new System.EventHandler(this.btnBruna_Click);
            // 
            // lblBruna
            // 
            this.lblBruna.AutoSize = true;
            this.lblBruna.BackColor = System.Drawing.Color.Transparent;
            this.lblBruna.Enabled = false;
            this.lblBruna.Font = new System.Drawing.Font("Euphorigenic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBruna.ForeColor = System.Drawing.Color.White;
            this.lblBruna.Location = new System.Drawing.Point(587, 327);
            this.lblBruna.Name = "lblBruna";
            this.lblBruna.Size = new System.Drawing.Size(158, 110);
            this.lblBruna.TabIndex = 2;
            this.lblBruna.Text = "Bruna \r\nSampaio";
            this.lblBruna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblBruna);
            this.Controls.Add(this.btnBruna);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnBruna;
        private Label lblBruna;
    }
}