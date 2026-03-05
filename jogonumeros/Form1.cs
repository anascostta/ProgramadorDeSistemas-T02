using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogonumeros
{
    public partial class frmJogoNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpiteJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoNumeros()
        {
            InitializeComponent();
        }

        private void frmJogoNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random(); //vai cirar um novo numero aleatório
            randomNumber = random.Next(1, 101); //número aleatório entre 1 e 100

        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {
            //Verifica se o jogo foi ganho

            if (jogoGanho)
            {
                txtResultado.Text = "Você já acertou o número! Reinicie o jogo para jogar novamente.";
                return;
            }

            //Verifica se o número de tentativas chegou a 0

            if (numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou. ";
                return;
            }

            //Validação do valor de palpite (entre 1 e 100)
            if (!int.TryParse(txtNumeroInserido.Text, out palpiteJogador) || palpiteJogador < 1 || palpiteJogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumerosTentativas.Text = numeroTentativas.ToString();
        }
    }
}
