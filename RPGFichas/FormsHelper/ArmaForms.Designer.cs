namespace RPGFichas.FormsHelper
{
    partial class ArmaForms
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
            this.components = new System.ComponentModel.Container();
            this.lblCritico = new System.Windows.Forms.Label();
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblDano = new System.Windows.Forms.Label();
            this.lblMunicao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtModificadores = new System.Windows.Forms.TextBox();
            this.txtEspecial = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMunicao = new System.Windows.Forms.TextBox();
            this.btnDano = new System.Windows.Forms.Button();
            this.btnCritico = new System.Windows.Forms.Button();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCritico
            // 
            this.lblCritico.AutoSize = true;
            this.lblCritico.BackColor = System.Drawing.Color.White;
            this.lblCritico.ContextMenuStrip = this.cmsForm;
            this.lblCritico.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCritico.Location = new System.Drawing.Point(174, 65);
            this.lblCritico.Name = "lblCritico";
            this.lblCritico.Size = new System.Drawing.Size(49, 20);
            this.lblCritico.TabIndex = 37;
            this.lblCritico.Text = "Crítico";
            // 
            // cmsForm
            // 
            this.cmsForm.Name = "contextMenuStrip1";
            this.cmsForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsForm.ShowImageMargin = false;
            this.cmsForm.Size = new System.Drawing.Size(36, 4);
            this.cmsForm.Text = "Opcões";
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.ContextMenuStrip = this.cmsForm;
            this.lblDano.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDano.Location = new System.Drawing.Point(10, 65);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(40, 20);
            this.lblDano.TabIndex = 36;
            this.lblDano.Text = "Dano";
            // 
            // lblMunicao
            // 
            this.lblMunicao.AutoSize = true;
            this.lblMunicao.ContextMenuStrip = this.cmsForm;
            this.lblMunicao.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMunicao.Location = new System.Drawing.Point(175, 134);
            this.lblMunicao.Name = "lblMunicao";
            this.lblMunicao.Size = new System.Drawing.Size(58, 20);
            this.lblMunicao.TabIndex = 35;
            this.lblMunicao.Text = "Munição";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ContextMenuStrip = this.cmsForm;
            this.lblTipo.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(10, 25);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 20);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.ContextMenuStrip = this.cmsForm;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Euphorigenic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(4, 177);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(274, 23);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "X";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtModificadores
            // 
            this.txtModificadores.BackColor = System.Drawing.Color.White;
            this.txtModificadores.ContextMenuStrip = this.cmsForm;
            this.txtModificadores.Enabled = false;
            this.txtModificadores.Location = new System.Drawing.Point(93, 113);
            this.txtModificadores.Name = "txtModificadores";
            this.txtModificadores.ReadOnly = true;
            this.txtModificadores.Size = new System.Drawing.Size(185, 23);
            this.txtModificadores.TabIndex = 29;
            // 
            // txtEspecial
            // 
            this.txtEspecial.BackColor = System.Drawing.Color.White;
            this.txtEspecial.ContextMenuStrip = this.cmsForm;
            this.txtEspecial.Enabled = false;
            this.txtEspecial.Location = new System.Drawing.Point(4, 150);
            this.txtEspecial.Name = "txtEspecial";
            this.txtEspecial.ReadOnly = true;
            this.txtEspecial.Size = new System.Drawing.Size(160, 23);
            this.txtEspecial.TabIndex = 30;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.ContextMenuStrip = this.cmsForm;
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(4, 42);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(181, 23);
            this.txtTipo.TabIndex = 25;
            // 
            // txtAtaque
            // 
            this.txtAtaque.BackColor = System.Drawing.Color.White;
            this.txtAtaque.ContextMenuStrip = this.cmsForm;
            this.txtAtaque.Enabled = false;
            this.txtAtaque.Location = new System.Drawing.Point(242, 4);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.ReadOnly = true;
            this.txtAtaque.Size = new System.Drawing.Size(36, 23);
            this.txtAtaque.TabIndex = 24;
            this.txtAtaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.BackColor = System.Drawing.Color.White;
            this.lblEspecial.ContextMenuStrip = this.cmsForm;
            this.lblEspecial.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspecial.Location = new System.Drawing.Point(10, 136);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(64, 20);
            this.lblEspecial.TabIndex = 39;
            this.lblEspecial.Text = "Especial:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.White;
            this.lblDuracao.ContextMenuStrip = this.cmsForm;
            this.lblDuracao.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuracao.Location = new System.Drawing.Point(-2, 114);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(96, 20);
            this.lblDuracao.TabIndex = 38;
            this.lblDuracao.Text = "Modificadores:";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.BackColor = System.Drawing.Color.White;
            this.lblAtaque.ContextMenuStrip = this.cmsForm;
            this.lblAtaque.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAtaque.Location = new System.Drawing.Point(188, 5);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(55, 20);
            this.lblAtaque.TabIndex = 33;
            this.lblAtaque.Text = "Ataque:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ContextMenuStrip = this.cmsForm;
            this.lblNome.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(-3, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 20);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.ContextMenuStrip = this.cmsForm;
            this.txtNome.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(45, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(145, 26);
            this.txtNome.TabIndex = 43;
            // 
            // txtMunicao
            // 
            this.txtMunicao.BackColor = System.Drawing.Color.White;
            this.txtMunicao.ContextMenuStrip = this.cmsForm;
            this.txtMunicao.Enabled = false;
            this.txtMunicao.Location = new System.Drawing.Point(170, 150);
            this.txtMunicao.Name = "txtMunicao";
            this.txtMunicao.ReadOnly = true;
            this.txtMunicao.Size = new System.Drawing.Size(106, 23);
            this.txtMunicao.TabIndex = 44;
            // 
            // btnDano
            // 
            this.btnDano.ContextMenuStrip = this.cmsForm;
            this.btnDano.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDano.Location = new System.Drawing.Point(2, 79);
            this.btnDano.Name = "btnDano";
            this.btnDano.Size = new System.Drawing.Size(155, 30);
            this.btnDano.TabIndex = 45;
            this.btnDano.UseVisualStyleBackColor = true;
            this.btnDano.Click += new System.EventHandler(this.btnDano_Click);
            // 
            // btnCritico
            // 
            this.btnCritico.ContextMenuStrip = this.cmsForm;
            this.btnCritico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCritico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCritico.Location = new System.Drawing.Point(163, 79);
            this.btnCritico.Name = "btnCritico";
            this.btnCritico.Size = new System.Drawing.Size(113, 30);
            this.btnCritico.TabIndex = 46;
            this.btnCritico.UseVisualStyleBackColor = true;
            this.btnCritico.Click += new System.EventHandler(this.btnCritico_Click);
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.BackColor = System.Drawing.Color.White;
            this.lblAlcance.ContextMenuStrip = this.cmsForm;
            this.lblAlcance.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlcance.Location = new System.Drawing.Point(198, 28);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(58, 20);
            this.lblAlcance.TabIndex = 47;
            this.lblAlcance.Text = "Alcance";
            // 
            // txtAlcance
            // 
            this.txtAlcance.BackColor = System.Drawing.Color.White;
            this.txtAlcance.ContextMenuStrip = this.cmsForm;
            this.txtAlcance.Enabled = false;
            this.txtAlcance.Location = new System.Drawing.Point(189, 42);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ReadOnly = true;
            this.txtAlcance.Size = new System.Drawing.Size(87, 23);
            this.txtAlcance.TabIndex = 48;
            // 
            // ArmaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 202);
            this.ContextMenuStrip = this.cmsForm;
            this.Controls.Add(this.lblEspecial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtModificadores);
            this.Controls.Add(this.txtEspecial);
            this.Controls.Add(this.txtAtaque);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblCritico);
            this.Controls.Add(this.lblDano);
            this.Controls.Add(this.btnDano);
            this.Controls.Add(this.btnCritico);
            this.Controls.Add(this.lblMunicao);
            this.Controls.Add(this.txtMunicao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArmaForms";
            this.Text = "ArmaForms";
            this.Load += new System.EventHandler(this.ArmaForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCritico;
        private Label lblDano;
        private Label lblMunicao;
        private Label lblTipo;
        private Button btnExcluir;
        private TextBox txtModificadores;
        private TextBox txtEspecial;
        private TextBox txtTipo;
        private TextBox txtAtaque;
        private Label lblEspecial;
        private Label lblDuracao;
        private Label lblAtaque;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtMunicao;
        private Button btnDano;
        private Button btnCritico;
        private Label lblAlcance;
        private TextBox txtAlcance;
        private ContextMenuStrip cmsForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator1;
    }
}