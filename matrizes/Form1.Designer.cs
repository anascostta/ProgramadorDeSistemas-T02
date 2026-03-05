namespace matrizes
{
    partial class frmMatrizes
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
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalvarDados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarDados.Location = new System.Drawing.Point(320, 371);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(164, 35);
            this.btnSalvarDados.TabIndex = 1;
            this.btnSalvarDados.Text = "Salvar Dados";
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.BackColor = System.Drawing.Color.LightCoral;
            this.btnExibirDados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExibirDados.Location = new System.Drawing.Point(304, 412);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(198, 39);
            this.btnExibirDados.TabIndex = 2;
            this.btnExibirDados.Text = "Exibir Dados";
            this.btnExibirDados.UseVisualStyleBackColor = false;
            this.btnExibirDados.Click += new System.EventHandler(this.btnExibirDados_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(162, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 29);
            this.txtNome.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(162, 87);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(522, 29);
            this.txtCPF.TabIndex = 5;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(162, 135);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(522, 29);
            this.txtContato.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(85, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 23);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCPF.Location = new System.Drawing.Point(106, 90);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(50, 23);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblContato.Location = new System.Drawing.Point(66, 138);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(90, 23);
            this.lblContato.TabIndex = 9;
            this.lblContato.Text = "Contato:";
            // 
            // dtgDados
            // 
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(27, 191);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(761, 161);
            this.dtgDados.TabIndex = 10;
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(810, 472);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExibirDados);
            this.Controls.Add(this.btnSalvarDados);
            this.Name = "frmMatrizes";
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.DataGridView dtgDados;
    }
}

