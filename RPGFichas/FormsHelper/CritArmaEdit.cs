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
    
    public partial class CritArmaEdit : Form
    {
        Ficha fichaSender;
        ArmaForms ArmaForms;
        public CritArmaEdit(Ficha sender, ArmaForms armaForms)
        {
            InitializeComponent();
            fichaSender = sender;
            ArmaForms = armaForms;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            fichaSender.editaCritico((Int32)numMargem.Value, (Int32)numMulti.Value, ArmaForms);
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
