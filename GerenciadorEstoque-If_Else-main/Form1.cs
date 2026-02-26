using System;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorEstoque
{
    public partial class frmGerenciadorEstoque : Form
    {
        public frmGerenciadorEstoque()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //criei um método para quado o usuario pressionar o botao enter no textbox

            if (e.KeyChar == (char)Keys.Enter) //escolhendo a tecla Enter
            {
                e.Handled = true; //se o usuario aperta-la 

                int estoque; //criei uma variavel int para armazenar o texto do txtEstoque

                if (int.TryParse(txtEstoque.Text, out estoque)) //tentando converter/passar o txtEstoque.Text na variavel estoque
                {
                    if (estoque < 5) //condicional <5
                    {
                        lblAlerta.Text = "Alerta: Baixo estoque. Por favor, reabasteça este produto.";
                        lblAlerta.ForeColor = Color.Red;//mudei a cor da fonte para red
                    }

                    else
                    {
                        lblAlerta.Text = "Estoque suficiente.";
                        lblAlerta.ForeColor = Color.Green;//mudei a cor da fonte para green
                    }
                }

                else //caso o usuario nao digite um nuero valido 
                {
                    lblAlerta.Text = "Digite um número válido.";//mostrara esse texto
                    lblAlerta.ForeColor = Color.Black;//na cor black

                }

            }
  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comando para tirar o azul que ficava no combobox
            this.ActiveControl = null;
           
        }
    }

}
