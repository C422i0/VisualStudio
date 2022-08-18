using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double n1, contador;
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            
            
            

            n1 = double.Parse(txtN.Text);
            
            if (n1 >=10 && n1 <= 150)
            {
                contador= contador + 1;
                txtEntre.Text = contador.ToString();
            }
            else
            {
                MessageBox.Show("Numero não atribuido");
            }
        }
    }
}
