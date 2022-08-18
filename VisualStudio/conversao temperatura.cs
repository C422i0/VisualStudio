using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            double f;
            double c;

            c = double.Parse(txtCel.Text);
            f = (9 * c + 160) / 5;

            txtFar.Text=f.ToString();
        }
    }
}
