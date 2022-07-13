namespace RPGFichas
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrestigio = new System.Windows.Forms.Label();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEspacos = new System.Windows.Forms.TextBox();
            this.txtPrestigio = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espacos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestigio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Euphorigenic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem.Location = new System.Drawing.Point(22, 44);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(84, 44);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item:";
            // 
            // lblPrestigio
            // 
            this.lblPrestigio.AutoSize = true;
            this.lblPrestigio.Font = new System.Drawing.Font("Euphorigenic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrestigio.Location = new System.Drawing.Point(626, 133);
            this.lblPrestigio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestigio.Name = "lblPrestigio";
            this.lblPrestigio.Size = new System.Drawing.Size(140, 44);
            this.lblPrestigio.TabIndex = 1;
            this.lblPrestigio.Text = "Prestígio:";
            // 
            // lblEspaco
            // 
            this.lblEspaco.AutoSize = true;
            this.lblEspaco.Font = new System.Drawing.Font("Euphorigenic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspaco.Location = new System.Drawing.Point(336, 133);
            this.lblEspaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(128, 44);
            this.lblEspaco.TabIndex = 2;
            this.lblEspaco.Text = "Espaços:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Euphorigenic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(22, 89);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(138, 44);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Detalhes:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(169, 51);
            this.txtItem.Name = "txtItem";
            this.txtItem.PlaceholderText = "Nome do Item";
            this.txtItem.Size = new System.Drawing.Size(693, 30);
            this.txtItem.TabIndex = 4;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(169, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição do Item (Função,Visual, Etc...)";
            this.txtDescricao.Size = new System.Drawing.Size(693, 30);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtEspacos
            // 
            this.txtEspacos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspacos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEspacos.Location = new System.Drawing.Point(483, 140);
            this.txtEspacos.MaxLength = 1;
            this.txtEspacos.Name = "txtEspacos";
            this.txtEspacos.Size = new System.Drawing.Size(93, 30);
            this.txtEspacos.TabIndex = 6;
            this.txtEspacos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEspacos.TextChanged += new System.EventHandler(this.txtEspacos_TextChanged);
            this.txtEspacos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtPrestigio
            // 
            this.txtPrestigio.Location = new System.Drawing.Point(773, 140);
            this.txtPrestigio.MaxLength = 1;
            this.txtPrestigio.Name = "txtPrestigio";
            this.txtPrestigio.Size = new System.Drawing.Size(89, 30);
            this.txtPrestigio.TabIndex = 7;
            this.txtPrestigio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrestigio.TextChanged += new System.EventHandler(this.txtPrestigio_TextChanged);
            this.txtPrestigio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade,
            this.Item,
            this.Detalhes,
            this.Espacos,
            this.Prestigio});
            this.dgvItens.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvItens.Enabled = false;
            this.dgvItens.GridColor = System.Drawing.Color.White;
            this.dgvItens.Location = new System.Drawing.Point(23, 203);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowTemplate.Height = 25;
            this.dgvItens.ShowEditingIcon = false;
            this.dgvItens.Size = new System.Drawing.Size(843, 64);
            this.dgvItens.TabIndex = 174;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Detalhes
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Detalhes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalhes.HeaderText = "Detalhes";
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            // 
            // Espacos
            // 
            this.Espacos.HeaderText = "Espaços";
            this.Espacos.Name = "Espacos";
            this.Espacos.ReadOnly = true;
            // 
            // Prestigio
            // 
            this.Prestigio.HeaderText = "Prestígio";
            this.Prestigio.Name = "Prestigio";
            this.Prestigio.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Silver;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Euphorigenic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.Location = new System.Drawing.Point(22, 285);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(844, 42);
            this.btnAddItem.TabIndex = 175;
            this.btnAddItem.Text = "Adicionar Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQtd.Location = new System.Drawing.Point(200, 140);
            this.txtQtd.MaxLength = 2;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(93, 30);
            this.txtQtd.TabIndex = 177;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Euphorigenic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(23, 133);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(175, 44);
            this.lblQuantidade.TabIndex = 176;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 348);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.txtPrestigio);
            this.Controls.Add(this.txtEspacos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblEspaco);
            this.Controls.Add(this.lblPrestigio);
            this.Controls.Add(this.lblItem);
            this.Font = new System.Drawing.Font("Euphorigenic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItem;
        private Label lblPrestigio;
        private Label lblEspaco;
        private Label lblDescricao;
        private TextBox txtItem;
        private TextBox txtDescricao;
        private TextBox txtEspacos;
        private TextBox txtPrestigio;
        private DataGridView dgvItens;
        private Button btnAddItem;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Detalhes;
        private DataGridViewTextBoxColumn Espacos;
        private DataGridViewTextBoxColumn Prestigio;
        private TextBox txtQtd;
        private Label lblQuantidade;
        private DataGridViewTextBoxColumn Quantidade;
    }
}