using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double imp;
            double dist;
            double custC;
            double custF;
            custF = double.Parse(txtCusto.Text);
            imp = (custF * 45) / 100;
            dist = (imp * 28) / 100;
            custC = custF + imp + dist;
            txtResult.Text=custC.ToString();
        }
    }
}
