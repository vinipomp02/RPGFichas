namespace RPGFichas.FormsHelper
{
    partial class PoderForm
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
            this.cbxPoder = new System.Windows.Forms.ComboBox();
            this.lblPoder = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblRequisito = new System.Windows.Forms.Label();
            this.txtRequisito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxPoder
            // 
            this.cbxPoder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPoder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPoder.BackColor = System.Drawing.Color.White;
            this.cbxPoder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPoder.Font = new System.Drawing.Font("Euphorigenic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPoder.FormattingEnabled = true;
            this.cbxPoder.Location = new System.Drawing.Point(58, 3);
            this.cbxPoder.Name = "cbxPoder";
            this.cbxPoder.Size = new System.Drawing.Size(248, 26);
            this.cbxPoder.TabIndex = 4;
            this.cbxPoder.SelectedIndexChanged += new System.EventHandler(this.cbxPoder_SelectedIndexChanged);
            // 
            // lblPoder
            // 
            this.lblPoder.AutoSize = true;
            this.lblPoder.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoder.Location = new System.Drawing.Point(2, 6);
            this.lblPoder.Name = "lblPoder";
            this.lblPoder.Size = new System.Drawing.Size(48, 20);
            this.lblPoder.TabIndex = 3;
            this.lblPoder.Text = "Poder:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Euphorigenic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(2, 61);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(304, 87);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Euphorigenic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(308, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 145);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "X";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(315, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Euphorigenic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(315, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(58, 104);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "Add Poder";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblElemento.Location = new System.Drawing.Point(2, 37);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(70, 20);
            this.lblElemento.TabIndex = 28;
            this.lblElemento.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.BackColor = System.Drawing.Color.White;
            this.txtElemento.Font = new System.Drawing.Font("Euphorigenic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtElemento.Location = new System.Drawing.Point(70, 33);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.ReadOnly = true;
            this.txtElemento.Size = new System.Drawing.Size(84, 25);
            this.txtElemento.TabIndex = 29;
            // 
            // lblRequisito
            // 
            this.lblRequisito.AutoSize = true;
            this.lblRequisito.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRequisito.Location = new System.Drawing.Point(155, 37);
            this.lblRequisito.Name = "lblRequisito";
            this.lblRequisito.Size = new System.Drawing.Size(41, 20);
            this.lblRequisito.TabIndex = 30;
            this.lblRequisito.Text = "Req.:";
            // 
            // txtRequisito
            // 
            this.txtRequisito.BackColor = System.Drawing.Color.White;
            this.txtRequisito.Font = new System.Drawing.Font("Euphorigenic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequisito.Location = new System.Drawing.Point(194, 34);
            this.txtRequisito.Name = "txtRequisito";
            this.txtRequisito.ReadOnly = true;
            this.txtRequisito.Size = new System.Drawing.Size(112, 25);
            this.txtRequisito.TabIndex = 31;
            // 
            // PoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 152);
            this.Controls.Add(this.txtRequisito);
            this.Controls.Add(this.lblRequisito);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbxPoder);
            this.Controls.Add(this.lblPoder);
            this.Font = new System.Drawing.Font("Euphorigenic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PoderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoderForm";
            this.Load += new System.EventHandler(this.PoderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxPoder;
        private Label lblPoder;
        private TextBox txtDescricao;
        private Button btnExcluir;
        private Button btnCancel;
        private Button btnAdicionar;
        private Label lblElemento;
        private TextBox txtElemento;
        private Label lblRequisito;
        private TextBox txtRequisito;
    }
}