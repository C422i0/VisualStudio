using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   double N1;
            double N2;

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int resultado;

            N1 = int.Parse(txtN1.Text);
            N2 = int.Parse(txtN2.Text);
            resultado = N1 + N2;
            txtSoma.Text = resultado.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            N1 = 0;
            N2 = 0;
            txtN1.Text = "";
            txtN2.Text = "";
            txtSoma.Text = "";

        }
    }
}
