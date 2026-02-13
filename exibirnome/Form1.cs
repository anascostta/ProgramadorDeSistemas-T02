using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exibirnome //nome da nossa pasta no computador
{
    public partial class frmExibirNome : Form //janela de design
    {
        public frmExibirNome()
        {
            InitializeComponent();
            //iniciar o programa, primeira tela a ser vista
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //código que vai acontecer ao clicar no botão
            string nome = txtNome.Text; //pegue o texto dessa caixa
            //vai guardar numa variável chamada nome o texto digitado dentro da caixa de texto
            MessageBox.Show("Meu nome é:" + "\n" + nome);
            //vai mostrar uma mensagem na tela da caixa de mensagem
            //o "\n" serve para pular uma linha
        }
    }
}
