using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayunidimensional
{
    public partial class formVetor : Form
    {
        public formVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //Matriz de uma dimensão, também chamada de vetor
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };
            //MessageBox.Show(pecasComputador[2]);
            // o messagebox vai mostrar a string do index 2 do array

            //foreach serve pra mostrar todos os itens de um array
            foreach(string peca in pecasComputador)
            {
                MessageBox.Show(peca);
            }
        }
    }
}
