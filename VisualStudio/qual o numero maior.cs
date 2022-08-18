using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;

            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            if (N1 > N2)
            {
                txtMaior.Text = "O maior é " + N1;
            }
            if (N2 > N1)
                {     
                txtMaior.Text = "O maior é " + N2;
            }
        }
    }
}
