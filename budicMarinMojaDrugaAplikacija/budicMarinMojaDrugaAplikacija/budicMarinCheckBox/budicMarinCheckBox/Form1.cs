using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void CheckBoxDorucak_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOdabrali.Text ="Dorucak";
        }

        private void CheckBoxRucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxVecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckSakriNarudzbu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxOdabraliSte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
