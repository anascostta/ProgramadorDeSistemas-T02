using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrizes
{
    public partial class frmMatrizes : Form
    {
        //primeiro declarei o tipo da variável (string), abri colchetes com uma virgula dentro para informar que estou criando uma matriz com linhas e colunas
        //minha matriz tera 20 linhas e 3 colunas
        //a declaracao da matriz esta na classe principal do programa
        string[,] matriz = new string[20, 3];
        int contLinha = 0; //variável que controla em qual linha da matriz os próximos dados serão armazenados

        public frmMatrizes()
        {
            InitializeComponent();

            dtgDados.ColumnCount = 3; // definindo quantas colunas minha matriz/tabela vai ter
            dtgDados.Columns[0].Name = ("Nome"); //na primeira coluna estou atribuindo o valor de "NOME" a primeira coluna
            dtgDados.Columns[1].Name = ("CPF"); // na segunda coluna aparece cpf    
            dtgDados.Columns[2].Name = ("Contato"); //na terceira coluna aparece contato
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            if (contLinha < 20)
                //se a minha contLinha for menor que 20, ele verifica se ainda resta linhas para acrescentar novas informações
            {
                //armazenar os dados na matriz de acordo com a linha
                matriz[contLinha, 0] = txtNome.Text;
                matriz[contLinha, 1] = txtCPF.Text;
                matriz[contLinha, 2] = txtContato.Text;

                contLinha++; //incrementar mais uma linha na matriz
                LimparCampos(); //limpa os campos para poder escrever novamente
                MessageBox.Show("Dados salvos na matriz!"); //assim que eu clicar em salvar aparece o messagebox com essa mensagem
            }

            else
                //se a contLinha nao for <20
            {
                MessageBox.Show("Capacidade máxima atingida");
                //aparece a mensagem que a capacidade maxima foi atingida
            }
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            //isso limpa os itens do dtg
            dtgDados.Rows.Clear();
            //aqui eu criei uma variavel para colunas e atribui a ela a quantidade de colunas da matriz
            int colunas = matriz.GetLength(1);

            for (int i =0; i<contLinha; i++)
                // i comeca em 0, enquanto i for menor que a quant de linha (contLinha), adiciona um ao valor de i
            {
                string[] coluna = new string[colunas];
                //aqui eu estou criando um vetor temporario para armazenar os dados da linha
                for(int j=0; j<colunas; j++)
                    //j comeca em 0, enquanto j for menor que colunas, incrementa 1
                {
                    coluna[j] = matriz[i, j];
                    // aqui to pegando o valor da matriz (linha i, coluna j) e atribuindo isso para o vetor
                }
                dtgDados.Rows.Add(coluna); // fora do ultimo for senao o programa da erro pq todas as colunas devem ser preenchidas, aqui vai exibir no dtg
            }
        }

        private void LimparCampos()
        {
            //criei esse metodo para limpar os campos toda vez que o usuario salvar os dados 
            txtNome.Clear();
            txtCPF.Clear();
            txtContato.Clear();
        }
    }
}
