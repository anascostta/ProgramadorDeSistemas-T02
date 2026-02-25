using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        double num1;
        string operacao;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(txtDisplay.Text);
            operacao = btn.Text;
            lblConta.Text = txtDisplay.Text + " " + operacao;
            txtDisplay.Clear();
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(txtDisplay.Text);
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
                        resultado = num1 / num2;

                    else
                    {
                        txtDisplay.Text = "Erro. Tente novamente!";
                        return;
                    }
                    break;
                    

                case "%":
                    resultado = num1 % num2;
                    break;
            }

            lblConta.Text += " " + num2 + " =" ;
            txtDisplay.Text = resultado.ToString();
        }

        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;

            double valor = Convert.ToDouble(txtDisplay.Text);
            valor = valor * -1;


            txtDisplay.Text = valor.ToString();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                if (txtDisplay.Text == "")
                    txtDisplay.Text = "0,"; // começa certo

                else
                    txtDisplay.Text += ",";
            }
        }


    }
}
