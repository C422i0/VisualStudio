using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            c=int.Parse(txtN1.Text);
            a=int.Parse(txtN2.Text);
            b = c;
            txtN3.Text=a.ToString();
            txtN4.Text=b.ToString();
        }
    }
}
