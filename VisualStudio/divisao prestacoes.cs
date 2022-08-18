using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            double Val;
            double Result;
            Val=double.Parse(txtVal.Text);

            Result = Val / 5;
                txtPrest.Text = Result.ToString();
        }
    }
}
