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
        public CheckBox? checkBoxPericiaMarcada { get; set; }
        public CheckBox? checkBoxRollsMarcada { get; set; }

        public void marcarCheckBox(CheckBox checkBox,string? tipoCheckBox)
        {

            checkBox.BackColor = Color.MediumBlue;
            switch (tipoCheckBox)
            { 
                case "Roll":
                    if (checkBoxRollsMarcada != null) desmarcarCheckBox(checkBoxRollsMarcada, tipoCheckBox);
                    checkBoxRollsMarcada = checkBox;
                    checkBox.Enabled = false;
                    break;
                default:
                    if (checkBoxPericiaMarcada != null) desmarcarCheckBox(checkBoxPericiaMarcada, tipoCheckBox);
                    checkBoxPericiaMarcada = checkBox;
                    break;
            }
            
        }
        public void desmarcarCheckBox(CheckBox checkBox, string? tipoCheckBox)
        {
            if (checkBox == null) return;
            checkBox.Checked = false;
            checkBox.BackColor = Color.White;

            switch (tipoCheckBox)
            {
                case "Roll":
                    checkBox.Enabled=true;
                    checkBoxRollsMarcada = null; 
                    break;
                default: checkBoxPericiaMarcada = null; break;
            }
        }
        public void selecionaCheckBox(object sender,string? tipoCheckBox)
        {
            var checkBox = sender as CheckBox;

            if (checkBox.Checked) marcarCheckBox(checkBox, tipoCheckBox);
            if (!checkBox.Checked) desmarcarCheckBox(checkBox, tipoCheckBox);
        }
        public void selecionaCheckBox(object sender) => selecionaCheckBox(sender, null);
        public void desmarcarCheckBox(CheckBox checkBox) => desmarcarCheckBox(checkBox, null);

    }
}
