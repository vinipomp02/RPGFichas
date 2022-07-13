namespace RPGFichas.FormsHelper
{
    partial class DanoArmaEdit
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
            this.lblDados = new System.Windows.Forms.Label();
            this.lblLados = new System.Windows.Forms.Label();
            this.cbxForca = new System.Windows.Forms.CheckBox();
            this.numDados = new System.Windows.Forms.NumericUpDown();
            this.numLados = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.lblBonus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(2, 11);
            this.lblDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(83, 31);
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Dados: ";
            // 
            // lblLados
            // 
            this.lblLados.AutoSize = true;
            this.lblLados.Location = new System.Drawing.Point(157, 11);
            this.lblLados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(82, 31);
            this.lblLados.TabIndex = 1;
            this.lblLados.Text = "Lados: ";
            // 
            // cbxForca
            // 
            this.cbxForca.AutoSize = true;
            this.cbxForca.Location = new System.Drawing.Point(531, 9);
            this.cbxForca.Name = "cbxForca";
            this.cbxForca.Size = new System.Drawing.Size(94, 35);
            this.cbxForca.TabIndex = 2;
            this.cbxForca.Text = "Força?";
            this.cbxForca.UseVisualStyleBackColor = true;
            // 
            // numDados
            // 
            this.numDados.Location = new System.Drawing.Point(73, 8);
            this.numDados.Margin = new System.Windows.Forms.Padding(4);
            this.numDados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDados.Name = "numDados";
            this.numDados.Size = new System.Drawing.Size(76, 37);
            this.numDados.TabIndex = 3;
            this.numDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDados.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLados
            // 
            this.numLados.Location = new System.Drawing.Point(226, 8);
            this.numLados.Margin = new System.Windows.Forms.Padding(6);
            this.numLados.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLados.Name = "numLados";
            this.numLados.Size = new System.Drawing.Size(89, 37);
            this.numLados.TabIndex = 4;
            this.numLados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLados.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.Location = new System.Drawing.Point(643, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 49);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // numBonus
            // 
            this.numBonus.Location = new System.Drawing.Point(394, 8);
            this.numBonus.Margin = new System.Windows.Forms.Padding(6);
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(89, 37);
            this.numBonus.TabIndex = 7;
            this.numBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(325, 11);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(83, 31);
            this.lblBonus.TabIndex = 6;
            this.lblBonus.Text = "Bonus: ";
            // 
            // DanoArmaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(747, 53);
            this.Controls.Add(this.numBonus);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numLados);
            this.Controls.Add(this.numDados);
            this.Controls.Add(this.cbxForca);
            this.Controls.Add(this.lblLados);
            this.Controls.Add(this.lblDados);
            this.Font = new System.Drawing.Font("Euphorigenic", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "DanoArmaEdit";
            this.Text = "danoArmaEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDados;
        private Label lblLados;
        private CheckBox cbxForca;
        private NumericUpDown numDados;
        private NumericUpDown numLados;
        private Button btnOk;
        private NumericUpDown numBonus;
        private Label lblBonus;
    }
}