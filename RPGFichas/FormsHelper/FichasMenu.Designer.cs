namespace RPGFichas.FormsHelper
{
    partial class FichasMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.lblPersonagem);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 431);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(280, 259);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "IMG";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPersonagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPersonagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonagem.Font = new System.Drawing.Font("Euphorigenic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonagem.ForeColor = System.Drawing.Color.Black;
            this.lblPersonagem.Location = new System.Drawing.Point(0, 258);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(280, 169);
            this.lblPersonagem.TabIndex = 2;
            this.lblPersonagem.Text = "Personagem";
            this.lblPersonagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonagem.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // FichasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 433);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FichasMenu";
            this.Text = "FichasMenu";
            this.Load += new System.EventHandler(this.FichasMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnImage;
        private Label lblPersonagem;
    }
}