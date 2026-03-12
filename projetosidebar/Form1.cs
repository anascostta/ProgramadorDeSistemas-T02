using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetosidebar
{
    public partial class frmTelaIncial : Form
    {
        private Form frmAtivo;
        public frmTelaIncial()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnlConteudo.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton (Button frmAtivo)
        {
            foreach(Control ctrl in pnlMenu.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Purple;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPerfil);
            FormShow(new frmPerfil());
        }
    }
}
