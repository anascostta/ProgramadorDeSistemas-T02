namespace projetosidebar
{
    partial class frmTelaIncial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaIncial));
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnMateriais = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnProjetos = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.Indigo;
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1196, 225);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Indigo;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(53, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(544, 71);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Aréa do Estudante";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.Lavender;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(336, 225);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(860, 829);
            this.pnlConteudo.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Lavender;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);
            this.pnlMenu.Controls.Add(this.btnMateriais);
            this.pnlMenu.Controls.Add(this.btnNotas);
            this.pnlMenu.Controls.Add(this.btnProjetos);
            this.pnlMenu.Controls.Add(this.btnAtividades);
            this.pnlMenu.Controls.Add(this.btnPerfil);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 225);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(336, 829);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Honeydew;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSair.FlatAppearance.BorderSize = 7;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(94, 671);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 81);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 535);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(336, 107);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnMateriais
            // 
            this.btnMateriais.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMateriais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMateriais.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnMateriais.FlatAppearance.BorderSize = 0;
            this.btnMateriais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriais.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriais.Image = ((System.Drawing.Image)(resources.GetObject("btnMateriais.Image")));
            this.btnMateriais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMateriais.Location = new System.Drawing.Point(0, 428);
            this.btnMateriais.Name = "btnMateriais";
            this.btnMateriais.Size = new System.Drawing.Size(336, 107);
            this.btnMateriais.TabIndex = 4;
            this.btnMateriais.Text = "Materiais";
            this.btnMateriais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMateriais.UseVisualStyleBackColor = false;
            this.btnMateriais.Click += new System.EventHandler(this.btnMateriais_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotas.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(0, 321);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(336, 107);
            this.btnNotas.TabIndex = 3;
            this.btnNotas.Text = "Notas";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnProjetos
            // 
            this.btnProjetos.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjetos.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnProjetos.FlatAppearance.BorderSize = 0;
            this.btnProjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjetos.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetos.Image = ((System.Drawing.Image)(resources.GetObject("btnProjetos.Image")));
            this.btnProjetos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjetos.Location = new System.Drawing.Point(0, 214);
            this.btnProjetos.Name = "btnProjetos";
            this.btnProjetos.Size = new System.Drawing.Size(336, 107);
            this.btnProjetos.TabIndex = 2;
            this.btnProjetos.Text = "Projetos";
            this.btnProjetos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjetos.UseVisualStyleBackColor = false;
            this.btnProjetos.Click += new System.EventHandler(this.btnProjetos_Click);
            // 
            // btnAtividades
            // 
            this.btnAtividades.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAtividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtividades.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAtividades.FlatAppearance.BorderSize = 0;
            this.btnAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividades.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtividades.Image = ((System.Drawing.Image)(resources.GetObject("btnAtividades.Image")));
            this.btnAtividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.Location = new System.Drawing.Point(0, 107);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(336, 107);
            this.btnAtividades.TabIndex = 1;
            this.btnAtividades.Text = "Atividades";
            this.btnAtividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtividades.UseVisualStyleBackColor = false;
            this.btnAtividades.Click += new System.EventHandler(this.btnAtividades_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPerfil.Size = new System.Drawing.Size(336, 107);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // frmTelaIncial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1196, 1054);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Name = "frmTelaIncial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyHub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnMateriais;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnProjetos;
        private System.Windows.Forms.Button btnAtividades;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSair;
    }
}

