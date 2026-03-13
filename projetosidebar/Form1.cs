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
            if (frmAtivo != null)
                frmAtivo.Close();

            frmAtivo = frm;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(frm);

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
       

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAtividades);
            FormShow(new frmAtividades());
        }

        private void btnProjetos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProjetos);
            FormShow(new frmProjetos());
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnNotas);
            FormShow(new frmNotas());
        }

        private void btnMateriais_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMateriais);
            FormShow(new frmMateriais());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnConfiguracoes);
            FormShow(new frmConfiguracoes());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
        }
    }
    
}
