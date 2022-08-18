using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_Lista2
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
            double Result;
            N1 = double.Parse(txtCust.Text);
            N2= double.Parse(txtAcre.Text);
            Result = N1 + N1 * N2 / 100;
            txtResult.Text = Result.ToString();
        }
    }
}
