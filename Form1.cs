using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasimples
{
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
            //quando compilar o projeto essa sera a tela que ira carregar
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //método que vai ser executado ao clicar no botão
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) + float.Parse(txtSegundoNumero.Text)).ToString();
            //float.Parse = vai passar um texto para número flutuante
            //To.String() = transforma um int,float,double... em string
        }

        private void lblSubtrair_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) - float.Parse(txtSegundoNumero.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) * float.Parse(txtSegundoNumero.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) / float.Parse(txtSegundoNumero.Text)).ToString();
       
        }
    }
}
