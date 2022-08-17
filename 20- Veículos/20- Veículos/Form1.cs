using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__Veículos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float anoCarro, valorCar, valorPag;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            anoCarro = float.Parse(txtAno.Text);
            valorCar = float.Parse(txtValor.Text);

            if (anoCarro < 2000)
            {
                valorPag = valorCar - (valorCar * 12) / 100;
                txtTotal.Text = "Total do carro com desconto de 12% é " + valorPag.ToString();
            }
            else
            {
                valorPag = valorCar - (valorCar * 7) / 100;
                txtTotal.Text = "Total do carro com desconto de 7% é " + valorPag.ToString();
            }


        }
    }
}
