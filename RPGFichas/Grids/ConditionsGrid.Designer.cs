namespace RPGFichas
{
    partial class ConditionsGrid
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
            this.dgvCondicoes = new System.Windows.Forms.DataGridView();
            this.btnAddCondicao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCondicoes
            // 
            this.dgvCondicoes.AllowUserToAddRows = false;
            this.dgvCondicoes.AllowUserToDeleteRows = false;
            this.dgvCondicoes.AllowUserToResizeRows = false;
            this.dgvCondicoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCondicoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCondicoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCondicoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCondicoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondicoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCondicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Euphorigenic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondicoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCondicoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCondicoes.GridColor = System.Drawing.Color.Black;
            this.dgvCondicoes.Location = new System.Drawing.Point(12, 3);
            this.dgvCondicoes.MultiSelect = false;
            this.dgvCondicoes.Name = "dgvCondicoes";
            this.dgvCondicoes.ReadOnly = true;
            this.dgvCondicoes.RowHeadersVisible = false;
            this.dgvCondicoes.RowTemplate.Height = 25;
            this.dgvCondicoes.Size = new System.Drawing.Size(969, 483);
            this.dgvCondicoes.TabIndex = 65;
            this.dgvCondicoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondicoes_CellClick);
            // 
            // btnAddCondicao
            // 
            this.btnAddCondicao.BackColor = System.Drawing.Color.Silver;
            this.btnAddCondicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCondicao.Font = new System.Drawing.Font("Euphorigenic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCondicao.Location = new System.Drawing.Point(12, 489);
            this.btnAddCondicao.Name = "btnAddCondicao";
            this.btnAddCondicao.Size = new System.Drawing.Size(969, 42);
            this.btnAddCondicao.TabIndex = 66;
            this.btnAddCondicao.Text = "Adicionar Condição";
            this.btnAddCondicao.UseVisualStyleBackColor = false;
            this.btnAddCondicao.Click += new System.EventHandler(this.btnAddCondicao_Click);
            // 
            // ConditionsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 534);
            this.Controls.Add(this.btnAddCondicao);
            this.Controls.Add(this.dgvCondicoes);
            this.Name = "ConditionsGrid";
            this.Text = "ConditionGrid";
            this.Load += new System.EventHandler(this.ConditionGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvCondicoes;
        private Button btnAddCondicao;
    }
}