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
        int contLinha = 0; //

        public frmMatrizes()
        {
            InitializeComponent();

            dtgDados.ColumnCount = 3;
            dtgDados.Columns[0].Name = ("Nome");
            dtgDados.Columns[1].Name = ("CPF");
            dtgDados.Columns[2].Name = ("Contato");
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            if (contLinha < 20)
            {
                //armazenar os dados na matriz de acordo com a linha
                matriz[contLinha, 0] = txtNome.Text;
                matriz[contLinha, 1] = txtCPF.Text;
                matriz[contLinha, 2] = txtContato.Text;

                contLinha++;
                LimparCampos();
                MessageBox.Show("Dados salvos na matriz!");
            }

            else
            {
                MessageBox.Show("Capacidade máxima atingida");
            }
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            dtgDados.Rows.Clear();
            int colunas = matriz.GetLength(1);

            for (int i =0; i<contLinha; i++)
            {
                string[] coluna = new string[colunas];
                for(int j=0; j<colunas; j++)
                {
                    coluna[j] = matriz[i, j];
                }
                dtgDados.Rows.Add(coluna);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtContato.Clear();
        }
    }
}
