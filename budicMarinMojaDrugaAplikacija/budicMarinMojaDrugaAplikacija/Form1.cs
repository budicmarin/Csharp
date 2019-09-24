using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinMojaDrugaAplikacija
{
    public partial class Form1 : Form
    {
        int broj = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            broj++;
            txtPrikaz.Text = broj+"";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            broj--;
            txtPrikaz.Text = broj.ToString();
        }

        private void TxtPrikaz_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
