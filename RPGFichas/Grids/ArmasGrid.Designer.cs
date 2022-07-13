namespace RPGFichas
{
    partial class ArmasGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArmas = new System.Windows.Forms.DataGridView();
            this.btnAddArma = new System.Windows.Forms.Button();
            this.lblNomeArma = new System.Windows.Forms.Label();
            this.txtNomeArma = new System.Windows.Forms.TextBox();
            this.lstModificadores = new System.Windows.Forms.ListBox();
            this.lblModificadores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArmas
            // 
            this.dgvArmas.AllowUserToAddRows = false;
            this.dgvArmas.AllowUserToDeleteRows = false;
            this.dgvArmas.AllowUserToResizeRows = false;
            this.dgvArmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArmas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArmas.BackgroundColor = System.Drawing.Color.White;
            this.dgvArmas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArmas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArmas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvArmas.GridColor = System.Drawing.Color.Black;
            this.dgvArmas.Location = new System.Drawing.Point(-1, 1);
            this.dgvArmas.MultiSelect = false;
            this.dgvArmas.Name = "dgvArmas";
            this.dgvArmas.ReadOnly = true;
            this.dgvArmas.RowHeadersVisible = false;
            this.dgvArmas.RowTemplate.Height = 25;
            this.dgvArmas.Size = new System.Drawing.Size(1457, 602);
            this.dgvArmas.TabIndex = 64;
            this.dgvArmas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArmas_CellClick);
            // 
            // btnAddArma
            // 
            this.btnAddArma.BackColor = System.Drawing.Color.Silver;
            this.btnAddArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArma.Font = new System.Drawing.Font("Euphorigenic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddArma.Location = new System.Drawing.Point(1259, 623);
            this.btnAddArma.Name = "btnAddArma";
            this.btnAddArma.Size = new System.Drawing.Size(186, 42);
            this.btnAddArma.TabIndex = 65;
            this.btnAddArma.Text = "Adicionar Arma";
            this.btnAddArma.UseVisualStyleBackColor = false;
            this.btnAddArma.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // lblNomeArma
            // 
            this.lblNomeArma.AutoSize = true;
            this.lblNomeArma.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeArma.Font = new System.Drawing.Font("Euphorigenic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeArma.Location = new System.Drawing.Point(-1, 637);
            this.lblNomeArma.Name = "lblNomeArma";
            this.lblNomeArma.Size = new System.Drawing.Size(107, 25);
            this.lblNomeArma.TabIndex = 66;
            this.lblNomeArma.Text = "Nome Arma:";
            // 
            // txtNomeArma
            // 
            this.txtNomeArma.Font = new System.Drawing.Font("Euphorigenic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeArma.Location = new System.Drawing.Point(112, 633);
            this.txtNomeArma.Name = "txtNomeArma";
            this.txtNomeArma.Size = new System.Drawing.Size(334, 32);
            this.txtNomeArma.TabIndex = 67;
            // 
            // lstModificadores
            // 
            this.lstModificadores.Font = new System.Drawing.Font("Euphorigenic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstModificadores.FormattingEnabled = true;
            this.lstModificadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstModificadores.ItemHeight = 20;
            this.lstModificadores.Items.AddRange(new object[] {
            "Certeira",
            "Cruel",
            "Discreta",
            "Perigosa",
            "Tática",
            "Alongada",
            "Calibre Grosso",
            "Compensador",
            "Discreta",
            "Ferrolho Automático",
            "Mira Laser",
            "Mira Telescópica",
            "Silenciador",
            "Tática",
            "Visão de Calor"});
            this.lstModificadores.Location = new System.Drawing.Point(620, 609);
            this.lstModificadores.MultiColumn = true;
            this.lstModificadores.Name = "lstModificadores";
            this.lstModificadores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstModificadores.Size = new System.Drawing.Size(577, 84);
            this.lstModificadores.TabIndex = 68;
            // 
            // lblModificadores
            // 
            this.lblModificadores.AutoSize = true;
            this.lblModificadores.BackColor = System.Drawing.Color.Transparent;
            this.lblModificadores.Font = new System.Drawing.Font("Euphorigenic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificadores.Location = new System.Drawing.Point(491, 636);
            this.lblModificadores.Name = "lblModificadores";
            this.lblModificadores.Size = new System.Drawing.Size(123, 25);
            this.lblModificadores.TabIndex = 69;
            this.lblModificadores.Text = "Modificadores:";
            // 
            // ArmasGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 692);
            this.Controls.Add(this.lblModificadores);
            this.Controls.Add(this.lstModificadores);
            this.Controls.Add(this.txtNomeArma);
            this.Controls.Add(this.lblNomeArma);
            this.Controls.Add(this.btnAddArma);
            this.Controls.Add(this.dgvArmas);
            this.Name = "ArmasGrid";
            this.Text = "ArmasGrid";
            this.Load += new System.EventHandler(this.ArmasGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvArmas;
        private Button btnAddArma;
        private Label lblNomeArma;
        private TextBox txtNomeArma;
        private ListBox listBox1;
        private ListBox lstModificadores;
        private Label lblModificadores;
    }
}