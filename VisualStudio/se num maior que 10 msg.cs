using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(txtN.Text);
            if (a > 10)
            {
                txtNum.Text = "Este numero é maior que dez.";
            }
            else
            {
                txtNum.Text = "Este numero é menor que dez.";
            }
        }
    }
}
