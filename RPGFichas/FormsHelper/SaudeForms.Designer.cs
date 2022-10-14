namespace RPGFichas.FormsHelper
{
    partial class SaudeForms
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbxDano = new System.Windows.Forms.CheckBox();
            this.cbxCura = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Euphorigenic", 48.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValue.Location = new System.Drawing.Point(15, 4);
            this.txtValue.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(182, 84);
            this.txtValue.TabIndex = 0;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // cbxDano
            // 
            this.cbxDano.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxDano.AutoSize = true;
            this.cbxDano.Checked = true;
            this.cbxDano.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDano.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxDano.Font = new System.Drawing.Font("Euphorigenic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxDano.ForeColor = System.Drawing.Color.White;
            this.cbxDano.Location = new System.Drawing.Point(208, 8);
            this.cbxDano.Name = "cbxDano";
            this.cbxDano.Size = new System.Drawing.Size(145, 76);
            this.cbxDano.TabIndex = 1;
            this.cbxDano.Text = "Perde";
            this.cbxDano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxDano.UseVisualStyleBackColor = true;
            this.cbxDano.CheckedChanged += new System.EventHandler(this.cbxDano_CheckedChanged);
            // 
            // cbxCura
            // 
            this.cbxCura.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxCura.AutoSize = true;
            this.cbxCura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCura.Font = new System.Drawing.Font("Euphorigenic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxCura.ForeColor = System.Drawing.Color.White;
            this.cbxCura.Location = new System.Drawing.Point(366, 9);
            this.cbxCura.Name = "cbxCura";
            this.cbxCura.Size = new System.Drawing.Size(162, 76);
            this.cbxCura.TabIndex = 2;
            this.cbxCura.Text = "Ganha";
            this.cbxCura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxCura.UseVisualStyleBackColor = true;
            this.cbxCura.CheckedChanged += new System.EventHandler(this.cbxCura_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(542, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 73);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SaudeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(653, 95);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxCura);
            this.Controls.Add(this.cbxDano);
            this.Controls.Add(this.txtValue);
            this.Font = new System.Drawing.Font("Euphorigenic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SaudeForms";
            this.Text = "SaudeForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValue;
        private CheckBox cbxDano;
        private CheckBox cbxCura;
        private Button btnOK;
    }
}