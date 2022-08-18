using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_3_Pag2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;
            double Med;
            N1 = double.Parse(txtDist.Text);
            N2 = double.Parse(txtCon.Text);
            Med = N1 / N2;
            txtConsMed.Text = Med.ToString();

        }
    }
}
