using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double r;
            double d;
            d=double.Parse(txtDep.Text);
            r = d + (d * 7) / 1000;
            txtJur.Text = r.ToString();
        }
    }
}
