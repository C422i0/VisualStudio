using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_5_Lista_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;
            double N3;
            double Media;
            N1 = double.Parse(txtNota1.Text);
            N2 = double.Parse(txtNota2.Text);
            N3 = double.Parse(txtNota3.Text);
            Media=(N1+N2+N3)/3;
            txtMedia.Text = Media.ToString();
        }
    }
}
