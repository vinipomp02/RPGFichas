namespace RPGFichas.FormsHelper
{
    partial class CritArmaEdit
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
            this.numMargem = new System.Windows.Forms.NumericUpDown();
            this.lblLados = new System.Windows.Forms.Label();
            this.lblMargem = new System.Windows.Forms.Label();
            this.numMulti = new System.Windows.Forms.NumericUpDown();
            this.lblMulti = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMargem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMulti)).BeginInit();
            this.SuspendLayout();
            // 
            // numMargem
            // 
            this.numMargem.Location = new System.Drawing.Point(83, 14);
            this.numMargem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.numMargem.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMargem.Name = "numMargem";
            this.numMargem.Size = new System.Drawing.Size(88, 32);
            this.numMargem.TabIndex = 7;
            this.numMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMargem.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblLados
            // 
            this.lblLados.AutoSize = true;
            this.lblLados.Location = new System.Drawing.Point(102, 18);
            this.lblLados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(69, 25);
            this.lblLados.TabIndex = 6;
            this.lblLados.Text = "Lados: ";
            // 
            // lblMargem
            // 
            this.lblMargem.AutoSize = true;
            this.lblMargem.Location = new System.Drawing.Point(9, 18);
            this.lblMargem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMargem.Name = "lblMargem";
            this.lblMargem.Size = new System.Drawing.Size(79, 25);
            this.lblMargem.TabIndex = 5;
            this.lblMargem.Text = "Margem:";
            // 
            // numMulti
            // 
            this.numMulti.Location = new System.Drawing.Point(287, 14);
            this.numMulti.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.numMulti.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMulti.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMulti.Name = "numMulti";
            this.numMulti.Size = new System.Drawing.Size(93, 32);
            this.numMulti.TabIndex = 10;
            this.numMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMulti.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(174, 18);
            this.lblMulti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(117, 25);
            this.lblMulti.TabIndex = 9;
            this.lblMulti.Text = "Multiplicador:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(392, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 49);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CritArmaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(499, 66);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numMulti);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.numMargem);
            this.Controls.Add(this.lblLados);
            this.Controls.Add(this.lblMargem);
            this.Font = new System.Drawing.Font("Euphorigenic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CritArmaEdit";
            this.Text = "CritArmaEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numMargem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMulti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numLados;
        private NumericUpDown numDados;
        private Label lblLados;
        private Label lblMargem;
        private NumericUpDown numericUpDown1;
        private Label lblMulti;
        private Button btnOk;
        private NumericUpDown numMargem;
        private NumericUpDown numMulti;
    }
}