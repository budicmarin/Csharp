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
            
        }

        private void CheckBoxRucak_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBoxVecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckSakriNarudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkSakriNarudzbu.Checked)
            {
                if (checkBoxDorucak.Checked)
                {
                    textBoxOdabrali.AppendText("Odabrali ste Dorucak. ");
                }
                if (checkBoxRucak.Checked)
                {
                    textBoxOdabrali.AppendText("\r\nOdabrali ste Rucak. ");
                }
                if (checkBoxVecera.Checked)
                {
                    textBoxOdabrali.AppendText("\r\nOdabrali ste Večeru. ");
                }
                
                
            }
            else
            {
                textBoxOdabrali.Clear();
            }

        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        
{
            if (checkSakriNarudzbu.Checked)
            {

            }
            else
            {
                textBoxOdabrali.Clear();
                if (checkBoxDorucak.Checked)
                {
                    textBoxOdabrali.AppendText("Odabrali ste Dorucak. ");
                }
                if (checkBoxRucak.Checked)
                {
                    textBoxOdabrali.AppendText("\r\nOdabrali ste Rucak. ");
                }
                if (checkBoxVecera.Checked)
                {
                    textBoxOdabrali.AppendText("\r\nOdabrali ste Večeru. ");
                }
            }
            
        }

        private void TextBoxOdabraliSte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
