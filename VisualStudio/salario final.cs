using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_4_Lista_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario;
            double vendas;
            double comissao;
            double salarioFinal;
            
          vendas=double.Parse(txtVendasTotal.Text);
            salario=double.Parse(txtSalarioFixo.Text);
            comissao = vendas * 15 / 100;
            salarioFinal = comissao + salario;
            txtSalarioTotal.Text = salarioFinal.ToString();
        }
    }
}
