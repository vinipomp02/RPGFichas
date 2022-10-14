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
    public partial class DanoArmaEdit : Form
    {
        Ficha fichaSender;
        ArmaForms ArmaForms;
        public DanoArmaEdit(Ficha sender,ArmaForms armaForms)
        {
            InitializeComponent();
            fichaSender = sender;
            ArmaForms = armaForms;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            fichaSender.editaDano((Int32)numDados.Value, (Int32)numLados.Value, (Int32)numBonus.Value, cbxForca.Checked, ArmaForms);
            this.Dispose();

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Dispose();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
