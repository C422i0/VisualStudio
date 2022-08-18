using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        double n1;
        double n2;
        string opcao;
        double teste;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // ISSO SERVE PARA SOMA, DIVISÃO, SUBTRAÇÃO E MULTIPLICAÇÃO.

            // Visor diferente de vazio para a operação ser feita, para que quando apertar o botão soma não dê erro,
            // o programa apenas não faz nada e espera inserir um número.
            if (txtVisor.Text != "")
            {
                // n1 diferente de 0, para que o programa entenda que n1 ja tem um valor e o próximo valor inserido no
                // visor vá para n2 e faça a soma de mais de dois números e não concatene os valores.
                if (n1 != 0)
                {
                    // conversão de string para double
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 + n2;
                    txtVisor.Text = "";
                    // conversão de double para string para aparecer o resultado da soma no visor
                    txtVisor.Text = n1.ToString();
                    // variável teste criada para que o programa veja quais números o teste é igual a 1, e após isso teste recebe 0 para
                    // que dê o limpa tela e o próximo número inserido não concatene com o valor da soma anterior, e sim que ele vá para n2
                    // e some com n1 (que é a soma dos dois primeiros números inseridos). 
                    teste = 1;
                }
            
                else
                {
                    // variável opcao criada para que ao somar somente dois números o botão igual vai fazer a leitura de uma escolha opcao e caso
                    // soma ele fará a soma dos números.
                    opcao = "soma";
                    // conversão de string para double.
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // aqui o programa faz a leitura de teste, sendo ele igual a 1, teste vai receber o valor 0 e vai limpar a tela, assim o número inserido no
            // visor não vai concatenar com o resultado da conta ja feita, o resultado sai da tela e fica apenas o número inserido.
            if (teste == 1)
            {
                // teste recebe 0 para dar o limpa tela para o próximo número ir para o visor sem concatenar com o resultado da conta feita anteriormente.
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
               teste = 0;
               txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                
                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 - n2;
                    txtVisor.Text = "";
                    txtVisor.Text = n1.ToString();
                    teste = 1;
                }

                else
                {
                    opcao = "soma";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }


            }
            txtN1.Text = n1.ToString();
            txtN2.Text = n2.ToString(); 
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {

                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 / n2;
                    txtVisor.Text = n1.ToString();
                    teste = 1;
                }
                else
                {
                    opcao = "divisao";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {

                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 * n2;
                    txtVisor.Text = n1.ToString();
                    teste = 1;
                }
                else
                {
                    opcao = "multiplicacao";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtVisor.Text);
            
            // variável opcao para que você queira fazer uma conta com apenas dois números e ele vai ver se é soma, subtração, divisão e multiplicação
            // caso seja um deles, ele passa pela fórmula da conta e da o resultado.
            switch (opcao)
            {
                case "soma":              
                        n1 = n1 + n2;                         
                    break;
                case "subtracao":
                    n1 = n1 - n2;
                    break;
                case "divisao":
                    n1 = n1 / n2;
                break;
                case "multiplicacao":
                    n1 = n1 * n2;
                    break;
                default:
                    break;
            }
              // mostra o resultado na tela.
              txtVisor.Text=n1.ToString();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // n1 e n2 recebe 0 para que a conta feita anteriormente seja apagada ao apertar o botão C e vai dar o limpa tela para começar
            // uma nova conta.
            n1 = 0;
            n2 = 0;
            txtVisor.Text = "";
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
           //criado para definir que o primeiro número inserido seja negativo.
           txtVisor.Text = "-";
        }

     
    }
}
