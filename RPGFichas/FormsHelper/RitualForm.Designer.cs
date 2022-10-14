namespace RPGFichas
{
    partial class RitualForm
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblRitual = new System.Windows.Forms.Label();
            this.cbxRitual = new System.Windows.Forms.ComboBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.txtCirculo = new System.Windows.Forms.TextBox();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.txtAcao = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(9, 212);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescricao.Size = new System.Drawing.Size(215, 118);
            this.txtDescricao.TabIndex = 9;
            // 
            // lblRitual
            // 
            this.lblRitual.AutoSize = true;
            this.lblRitual.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRitual.Location = new System.Drawing.Point(2, 5);
            this.lblRitual.Name = "lblRitual";
            this.lblRitual.Size = new System.Drawing.Size(50, 20);
            this.lblRitual.TabIndex = 10;
            this.lblRitual.Text = "Ritual:";
            // 
            // cbxRitual
            // 
            this.cbxRitual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRitual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRitual.BackColor = System.Drawing.Color.White;
            this.cbxRitual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxRitual.FormattingEnabled = true;
            this.cbxRitual.Location = new System.Drawing.Point(53, 2);
            this.cbxRitual.Name = "cbxRitual";
            this.cbxRitual.Size = new System.Drawing.Size(169, 26);
            this.cbxRitual.TabIndex = 1;
            this.cbxRitual.SelectedIndexChanged += new System.EventHandler(this.cbxRitual_SelectedIndexChanged);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.BackColor = System.Drawing.Color.White;
            this.lblElemento.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblElemento.Location = new System.Drawing.Point(2, 37);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(70, 20);
            this.lblElemento.TabIndex = 11;
            this.lblElemento.Text = "Elemento:";
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCirculo.Location = new System.Drawing.Point(7, 60);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(51, 20);
            this.lblCirculo.TabIndex = 12;
            this.lblCirculo.Text = "Circulo";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCusto.Location = new System.Drawing.Point(116, 60);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(41, 20);
            this.lblCusto.TabIndex = 13;
            this.lblCusto.Text = "Custo";
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcao.Location = new System.Drawing.Point(11, 105);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(43, 20);
            this.lblAcao.TabIndex = 14;
            this.lblAcao.Text = "Ação:";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.BackColor = System.Drawing.Color.White;
            this.lblAlcance.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlcance.Location = new System.Drawing.Point(114, 105);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(62, 20);
            this.lblAlcance.TabIndex = 15;
            this.lblAlcance.Text = "Alcance:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.White;
            this.lblDuracao.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuracao.Location = new System.Drawing.Point(3, 154);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(63, 20);
            this.lblDuracao.TabIndex = 16;
            this.lblDuracao.Text = "Duração:";
            // 
            // lblResistencia
            // 
            this.lblResistencia.AutoSize = true;
            this.lblResistencia.BackColor = System.Drawing.Color.White;
            this.lblResistencia.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResistencia.Location = new System.Drawing.Point(3, 183);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(84, 20);
            this.lblResistencia.TabIndex = 17;
            this.lblResistencia.Text = "Resistência:";
            // 
            // txtElemento
            // 
            this.txtElemento.BackColor = System.Drawing.Color.White;
            this.txtElemento.Location = new System.Drawing.Point(71, 35);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.ReadOnly = true;
            this.txtElemento.Size = new System.Drawing.Size(151, 25);
            this.txtElemento.TabIndex = 2;
            // 
            // txtCirculo
            // 
            this.txtCirculo.BackColor = System.Drawing.Color.White;
            this.txtCirculo.Location = new System.Drawing.Point(2, 78);
            this.txtCirculo.Name = "txtCirculo";
            this.txtCirculo.ReadOnly = true;
            this.txtCirculo.Size = new System.Drawing.Size(101, 25);
            this.txtCirculo.TabIndex = 3;
            // 
            // txtResistencia
            // 
            this.txtResistencia.BackColor = System.Drawing.Color.White;
            this.txtResistencia.Location = new System.Drawing.Point(88, 180);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.ReadOnly = true;
            this.txtResistencia.Size = new System.Drawing.Size(135, 25);
            this.txtResistencia.TabIndex = 8;
            // 
            // txtDuracao
            // 
            this.txtDuracao.BackColor = System.Drawing.Color.White;
            this.txtDuracao.Location = new System.Drawing.Point(72, 151);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.ReadOnly = true;
            this.txtDuracao.Size = new System.Drawing.Size(152, 25);
            this.txtDuracao.TabIndex = 7;
            // 
            // txtAlcance
            // 
            this.txtAlcance.BackColor = System.Drawing.Color.White;
            this.txtAlcance.Location = new System.Drawing.Point(107, 120);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ReadOnly = true;
            this.txtAlcance.Size = new System.Drawing.Size(117, 25);
            this.txtAlcance.TabIndex = 6;
            // 
            // txtAcao
            // 
            this.txtAcao.BackColor = System.Drawing.Color.White;
            this.txtAcao.Location = new System.Drawing.Point(5, 120);
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.ReadOnly = true;
            this.txtAcao.Size = new System.Drawing.Size(96, 25);
            this.txtAcao.TabIndex = 5;
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.White;
            this.txtCusto.Location = new System.Drawing.Point(109, 78);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.ReadOnly = true;
            this.txtCusto.Size = new System.Drawing.Size(113, 25);
            this.txtCusto.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Euphorigenic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(8, 337);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(165, 59);
            this.btnAdicionar.TabIndex = 21;
            this.btnAdicionar.Text = "Adicionar Ritual";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(179, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 59);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Euphorigenic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(8, 337);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(214, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "X";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagem.Location = new System.Drawing.Point(2, 366);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(222, 215);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 23;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Visible = false;
            // 
            // RitualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(226, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtAcao);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.txtResistencia);
            this.Controls.Add(this.txtCirculo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblResistencia);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.cbxRitual);
            this.Controls.Add(this.lblRitual);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.pbxImagem);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Euphorigenic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RitualForm";
            this.Text = "RitualForm";
            this.Load += new System.EventHandler(this.RitualForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDescricao;
        private Label lblCirculo;
        private ComboBox cbxRitual;
        private Label lblRitual;
        private Label lblElemento;
        private Label lblCusto;
        private Label lblComponente;
        private Label lblAcao;
        private Label lblAlcance;
        private Label lblAlvo;
        private Label lblDuracao;
        private Label lblResistencia;
        private TextBox txtElemento;
        private TextBox txtCirculo;
        private TextBox txtResistencia;
        private TextBox txtDuracao;
        private TextBox txtAlcance;
        private TextBox txtAlvo;
        private TextBox txtAcao;
        private TextBox txtComponente;
        private TextBox txtCusto;
        private Button btnAdicionar;
        private Button btnCancel;
        private Button btnExcluir;
        private PictureBox pbxImagem;
    }
}