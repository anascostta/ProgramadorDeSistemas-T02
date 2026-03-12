using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telalogin
{
    public partial class frmSistemaDeLogin : Form
    {
        public frmSistemaDeLogin()
        {
            InitializeComponent();
        }

        int tentativas;
        string senhaInserida = "";
        private void button1_Click(object sender, EventArgs e)
        {
            while (tentativas < 3)//uso um while para administrar o numero de tentativas
            {
                //Atribui a variavel com nome senhaInserida o texto escrito pelo usuario em txtSenha 
                senhaInserida = txtSenha.Text;
                if (senhaInserida == "Senha123")
                    //se a senhaInserida pelo usuario for igual a "Senha123"
                {
                    //Aparece uma mensagem de acesso liberado
                    MessageBox.Show("Acesso liberado!");
                }
                else
                //se a senhaInserida não for igual a "Senha123"
                {
                    //vai incrementar 1 no valor de tentativas
                    tentativas++;
                    //vai aparecer uma mensagem de senha invalida
                    MessageBox.Show("Senha inválida. Tente novamente!");

                    if (tentativas == 3)
                        //aqui eu verifico se o n de tentativas for igual a 3
                    {
                        //se for igual ai eu mostro essa mensagem de limite excedido e conta bloqueada
                        MessageBox.Show("Conta bloqueada. Limite de tentativas excedido!");
                    }
                   
                }
                //limpa o campo de senha para poder inserir novamente
                txtSenha.Clear();
                //deixa o foco no campo de senha, pq sera inserida novamente
                txtSenha.Focus();
                return;
            }
        }
    }
}
