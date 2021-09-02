using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Calculadora_v1
{
    public partial class FormCalc : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public FormCalc()
        {
            InitializeComponent();
        }

        private void CalcBox_TextChanged(object sender, EventArgs e)
        {
            calcBox.MaxLength = 11;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            calcBox.Text = "";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            calcBox.Text += "0";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            calcBox.Text += "1";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            calcBox.Text += "2";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            calcBox.Text += "3";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            calcBox.Text += "4";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            calcBox.Text += "5";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            calcBox.Text += "6";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calcBox.Text += "8";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calcBox.Text += "9";
        }

        private void PlusButton_Click(object sender, EventArgs e)

        {
            // tratamento
            if (calcBox.Text != "")
            {
                // ctrl ponto (.) para importar a biblioteca CultureInfo
                // .InvariantCulture para considerear (.) como ponto decimal
                valor1 += decimal.Parse(calcBox.Text, CultureInfo.InvariantCulture);

                //limpar meu calcBox
                calcBox.Text = "";

                //informar ao sistema que é uma SOMA
                operacao = "SOMA";

                //informar ao usuário que é soma
                labelOperador.Text = "( + )";
            }
            else
            {
                MessageBox.Show("Operador já Informado, informe o próximo números");
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (calcBox.Text != "")
            {
                //informar ao usuário que é Divisão
                labelOperador.Text = "( = )";
                valor2 += decimal.Parse(calcBox.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    calcBox.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUBTRAIR")
                {
                    calcBox.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICAR")
                {
                    calcBox.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIVIDIR")
                {
                    calcBox.Text = Convert.ToString(valor1 / valor2);
                }
            }
                
        }

        private void Button7_Click(object sender, EventArgs e)        
        {
            if (calcBox.Text != "")
            {

                // ctrl ponto (.) para importar a biblioteca CultureInfo
                // .InvariantCulture para considerear (.) como ponto decimal
                valor1 += decimal.Parse(calcBox.Text, CultureInfo.InvariantCulture);

                //limpar meu calcBox
                calcBox.Text = "";

                //informar ao sistema que é uma SUBTRAÇÃO
                operacao = "SUBTRAIR";

                //informar ao usuário que é Subtração
                labelOperador.Text = "( - )";
            }
            else
            {
                MessageBox.Show("Operador já Informado, informe o próximo números");
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (calcBox.Text != "")
            {
                // ctrl ponto (.) para importar a biblioteca CultureInfo
                // .InvariantCulture para considerear (.) como ponto decimal
                valor1 += decimal.Parse(calcBox.Text, CultureInfo.InvariantCulture);

                //limpar meu calcBox
                calcBox.Text = "";

                //informar ao sistema que é uma MULTIPLICAÇÃO
                operacao = "MULTIPLICAR";

                //informar ao usuário que é Multiplicação
                labelOperador.Text = "( X )";
            }
            else
            {
                MessageBox.Show("Operador já Informado, informe o próximo números");
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (calcBox.Text != "")
            {
                // ctrl ponto (.) para importar a biblioteca CultureInfo
                // .InvariantCulture para considerear (.) como ponto decimal
                valor1 += decimal.Parse(calcBox.Text, CultureInfo.InvariantCulture);

                //limpar meu calcBox
                calcBox.Text = "";

                //informar ao sistema que é uma Divisão
                operacao = "DIVIDIR";

                //informar ao usuário que é Divisão
                labelOperador.Text = "( / )";
            }
            else
            {
                MessageBox.Show("Operador já Informado, informe o próximo números");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            calcBox.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperador.Text = "";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            calcBox.Text += "7";
        }

        private void BotaoPonto_PreviewTextInput(object sender, EventArgs e)
        {
           
        }

        private void BotaoPonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CalcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente Número e Ponto");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente UM Ponto");
            }
        }

        private void BotaoPonto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BotaoMais_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (calcBox.Text.Contains("."))
            {
                MessageBox.Show("O Ponto já foi incluso!");
            }
            else
            {
                calcBox.Text += ".";
            }
        }

    }
}
