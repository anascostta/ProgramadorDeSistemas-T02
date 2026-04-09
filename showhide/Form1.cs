using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showhide
{
    public partial class frmShowHide : Form
    {
        public frmShowHide()
        {
            InitializeComponent();
            pbLogotipo.Visible = false; // inicializa invisel para o usuario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pbLogotipo.Visible) //se o logo estiver visivel
            {
                pbLogotipo.Hide(); //esconder o picture box
                btnMostrarLogo.Text = "Mostrar Logo"; // muda o texto do botao
            }

            else //se estiver invisivel
            {
                pbLogotipo.Show(); //vai mostrar o picture box
                btnMostrarLogo.Text = "Esconder Logo";
            }
        }

        private void pbLogotipo_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome(); //instancia um novo formulário
            form.Show(); //exibe o form
            this.Hide(); //esconde o form que estava aberto
        }
    }
}
