using ProgressBarSample;
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
    public partial class SaudeForms : Form
    {
        private TextProgressBar tpbSender;
        public SaudeForms(TextProgressBar tpb)
        {
            InitializeComponent();
            tpbSender = tpb;
        }

        private void cbxCura_CheckedChanged(object sender, EventArgs e) => cbxDano.Checked = !cbxCura.Checked;

        private void cbxDano_CheckedChanged(object sender, EventArgs e) => cbxCura.Checked = !cbxDano.Checked;

        private void VerificaInt(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e) => VerificaInt(sender, e);

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtValue.Text==null || txtValue.Text == "") 
            {
                this.Dispose();
                return; 
            }
            int value = int.Parse(txtValue.Text);
            if (cbxCura.Checked)
            {
                for (int i = 0; i < value; i++)
                {
                    if (tpbSender.Value == tpbSender.Maximum)
                    {
                        tpbSender.Incremento += 1;
                    }
                    else
                    {
                        tpbSender.Increment(1);
                    }
                }
                
            }
            else
            {
                for (int i = 0; i < value; i++)
                {
                    if (tpbSender.Incremento > 0)
                    {
                        tpbSender.Incremento -= 1;
                    }
                    else
                    {
                        tpbSender.Increment(-1);
                    }
                }
            }

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
