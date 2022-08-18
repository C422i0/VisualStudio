using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18__idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;
            int n4;
            int n5;

            n1 = int.Parse(txtIdade1.Text);
            n2 = int.Parse(txtIdade2.Text);
            n3 = int.Parse(txtIdade3.Text);
            n4 = int.Parse(txtIdade4.Text);
            n5 = int.Parse(txtIdade5.Text);

            if (n1 >= 18)
            {
                txtResp1.Text = "Maior de idade";
            }
            else
            {
                txtResp1.Text = "Menor de idade";
            }

            if (n2 >= 18)
            {
                txtResp2.Text = "Maior de idade";
            }
            else
            {
                txtResp2.Text = "Menor de idade";
            }

            if (n3 >= 18)
            {
                txtResp3.Text = "Maior de idade";
            }
            else
            {
                txtResp3.Text = "Menor de idade";
            }

            if (n4 >= 18)
            {
                txtResp4.Text = "Maior de idade";
            }
            else
            {
                txtResp4.Text = "Menor de idade";
            }

            if (n5 >= 18)
            {
                txtResp5.Text = "Maior de idade";
            }
            else
            {
                txtResp5.Text = "Menor de idade";
            }
        }
    }
}
