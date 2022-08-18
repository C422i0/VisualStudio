using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex15_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(txtN1.Text);
            if (a <= 200)
            {
                txtNum.Text = "Este numero esta entre 100 e 200";
            }
            if (a < 200)
            {
                txtNum.Text = "Este numero não esta entre 100 e 200";
            }
        }
    }
}
