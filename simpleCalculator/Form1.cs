using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
  
    public partial class Form1 : Form
    {
        double num1;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender; // aqui eu estou criando um botão e coloquei o nome de "click"
            txtDisplay.Text += click.Text; // aqui exibe no display o "click", ou seja o que esta escrito no botao sera adicionado
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = " "; // aqui eu adiciono um caractere em "branco" para excluir o texto já digitado
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            num1 = double.Parse(txtDisplay.Text);
            operacao = click.Text;
            txtDisplay.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(txtDisplay.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        break;
                    }
                    else 
                    {
                        txtDisplay.Text = "Erro!";
                        return;
                    }
                    break;
                case "%":
                    resultado = num1 % num2;
                    break;
            }
            txtDisplay.Text = resultado.ToString();
        }

        private void btnMaisouMenos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") ;
            return;
            double valor = double.Parse(txtDisplay.Text);
            valor = valor * -1;
            txtDisplay.Text = valor.ToString();
        }
    }
}
