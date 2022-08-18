using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome, sexo;
        int totalH, totalM;
        private void btnResultado_Click(object sender, EventArgs e)
        {
            

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;

            if (txtSexo.Text == "homem")
            {
                totalH = totalH + 1;
            }
            else
            {
                totalM = totalM + 1;
            }
            txtSexoH.Text = totalH.ToString();
            txtSexoM.Text = totalM.ToString();
        }
    }
}
