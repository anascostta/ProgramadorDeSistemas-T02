using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DadosNecessarios
{
    public partial class frmFormSimples : Form
    {
        public frmFormSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro; //declarando as variaveis para armazenar o valor digitado pelo usuario
            string nomeUsuario; //declarando as variaveis para armazenar o valor digitado pelo usuario
            DateTime dataNascimento; //declarando as variaveis para armazenar o valor digitado pelo usuario
            string cidade; //declarando as variaveis para armazenar o valor digitado pelo usuario
            bool generoF; // a opção escolhida será True e as outras falsas
            bool generoM; // a opção escolhida será True e as outras falsas
            bool generoNB; // a opção escolhida será True e as outras falsas

            //1 - Design
            //2 - Declarar as variáveis digitadas
            //3 - Validar campo

            //Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text)) // checa se o espaço esta vazio
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return;// Interrompe a execução do código caso o campo esteja vazio
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.");
                return;// Interrompe a execução do código caso o campo esteja vazio
            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade.");
                return;// Interrompe a execução do código caso o campo esteja vazio
            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && rbNaoBinario.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return;// Interrompe a execução do código caso o campo esteja vazio
            }

            //Agora, caso todos os campos estejam preenchidos, a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determinar o gênero selecionado
            string generoSelecionado = "Não informado"; //Caso nenhum gênero seja selecionado
            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else if (generoNB)
                generoSelecionado = "Não Binário";


                //Exibir as informações em MessageBox   
                MessageBox.Show("Número cadastrado: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero: " + generoSelecionado);
        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }
}
