using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetosidebar
{
    public partial class frmTelaIncial : Form
    {
        private Form frmAtivo; //variavel para guardar o formulario
        public frmTelaIncial()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            if (frmAtivo != null) //verifica se o form esta aberto
                frmAtivo.Close(); //fecha o form

            frmAtivo = frm;

            frm.TopLevel = false; //define que o formulario nao sera aberto em uma nova janela
            frm.FormBorderStyle = FormBorderStyle.None; //define que nao tera bordas, vai apenas encaixar no panel
            frm.Dock = DockStyle.Fill; //dock do formulario

            pnlConteudo.Controls.Clear(); //remove todos os controles do panel
            pnlConteudo.Controls.Add(frm); //adiciona o formulario dentro do panel

            frm.Show(); //exibe o form dentro do panel
        }

        private void ActiveButton (Button frmAtivo)
        {
            //criando um metodo para mudar o design dos buttons ao serem clicados 
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

        public class RoundedPanel : Panel
        {
            public int BorderRadius { get; set; } = 20; // Raio do arredondamento

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                // Melhora a qualidade do desenho
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Cria os arcos nos cantos
                    path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
                    path.AddArc(rect.Width - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
                    path.AddArc(rect.Width - BorderRadius, rect.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                    path.AddArc(rect.X, rect.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                    path.CloseAllFigures();

                    // Aplica a região arredondada
                    this.Region = new Region(path);
                }
            }
        }
    }
    
}
