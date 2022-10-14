using RPGFichas.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFichas.FormsHelper
{
    public partial class ArmaForms : Form
    {
        Ficha Ficha;
        Label MelhorDado;
        private Arma Arma;
        private string Nome;
        private string[] Modificadores;
        public ArmaForms(Ficha sender, Label dado, Arma arma, string? nome, string[] modificadores)
        {
            InitializeComponent();
            Ficha = sender;
            MelhorDado = dado;
            Arma = arma;
            Nome = nome;
            Modificadores = modificadores;
        }


        private void btnDano_Click(object sender, EventArgs e) => Ficha.DgvComportamento.DgvArmasActions(btnDano.Text, null, MelhorDado);
        private void btnCritico_Click(object sender, EventArgs e) => Ficha.DgvComportamento.DgvArmasActions(btnDano.Text, btnCritico.Text, MelhorDado);

        private void ArmaForms_Load(object sender, EventArgs e)
        {
            txtNome.Text = Nome;
            if (Arma == null) return;

            if (Arma.Ataque == "Pontaria") txtAtaque.Text = Ficha.Controls["cbxPontaria"].Text;
            if (Arma.Ataque == "Luta") txtAtaque.Text = Ficha.Controls["cbxLuta"].Text;
            txtModificadores.Text = string.Join(", ", Modificadores);

            txtMunicao.Text = Arma.Municao;
            txtAlcance.Text = Arma.Alcance;

            if (Nome != null) txtNome.Text = Nome;
            else txtNome.Text = Arma.Name;

            txtTipo.Text = Arma.Name + " (" + Arma.Tipo + ")";

            txtEspecial.Text = Arma.Especial;

            btnCritico.Text = Arma.Critico;
            if (Arma.Dano != null) btnDano.Text = Arma.Dano.Replace("F", Ficha.Controls["btnFor"].Text.ToString());

            Ficha.DgvComportamento.ModificaArma(this, Modificadores);

            this.TopLevel = false;

            List<ToolStripMenuItem> toolStripItem = new();

            ToolStripMenuItem toolStripItem1 = new();

            ToolStripMenuItem toolStripItem2 = new();
            toolStripItem2.Text = "Editar Dano";
            toolStripItem2.Click += new EventHandler((sender, arg) => Ficha.abreEdicaoDano(this));
            toolStripItem.Add(toolStripItem2);

            ToolStripMenuItem toolStripItem3 = new();
            toolStripItem3.Text = "Editar Critico";
            toolStripItem3.Click += new EventHandler((sender, args) => Ficha.abreEdicaoCrit(this));
            toolStripItem.Add(toolStripItem3);

            foreach (var item in toolStripItem)
            {
                cmsForm.Items.Add(item);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var excluir = MessageBox.Show($"Deseja Mesmo Excluir a Arma: {txtNome.Text}","Excluir Arma",MessageBoxButtons.YesNo);
            if (excluir == DialogResult.No) return;

            Ficha.ExcluirArma(txtNome.Text);
            this.Dispose();

        }

    }
}
