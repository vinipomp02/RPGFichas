using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFichas.Domain
{
    public class CheckboxComportamento
    {
        public CheckBox ultimaCheckBox { get; set; }

        public void marcarCheckBox(CheckBox cbxPericia)
        {
            if (ultimaCheckBox != null) ultimaCheckBox.Checked = false;
            ultimaCheckBox = cbxPericia;
        }
    }
}
