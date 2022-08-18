using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16_Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media;
            double nota1;
            double nota2;
                double nota3;
            nota1 = double.Parse (txtNt1.Text);
            nota2 = double.Parse (txtNt2.Text);
            nota3 = double.Parse (txtNt3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            txtmedia.Text = media.ToString();
            
            if (media >= 6.9)
            {
                txtapro.Text = "Aprovado";
            }
            else
            {
                txtapro.Text = "Recuperação";
            }
            
            if(media < 5)
            {
                txtapro.Text = "Reprovado";
            }
            
        }
    }
}
