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
            while (tentativas < 3)
            {
                senhaInserida = txtSenha.Text;
                if (senhaInserida == "Senha123")
                {
                    MessageBox.Show("Acesso liberado!");
                }
                else
                {
                    tentativas++;
                    MessageBox.Show("Senha inválida. Tente novamente!");

                    if (tentativas == 3)
                    {
                        MessageBox.Show("Limite de tentativas excedido!");
                    }
                   
                }
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }
        }
    }
}
