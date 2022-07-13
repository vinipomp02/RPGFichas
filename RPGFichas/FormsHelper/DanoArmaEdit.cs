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
        int rowEdit;
        public DanoArmaEdit(Ficha sender,int row)
        {
            InitializeComponent();
            fichaSender = sender;
            rowEdit = row;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            fichaSender.editaDano((Int32)numDados.Value, (Int32)numLados.Value, (Int32)numBonus.Value, cbxForca.Checked,rowEdit);
            this.Dispose();

        }
    }
}
