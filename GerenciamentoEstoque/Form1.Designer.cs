namespace GerenciamentoEstoque
{
    partial class frmGerenciadorEstoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstoqueAtualizado = new System.Windows.Forms.Label();
            this.lblQuantidadeAtualizada = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtQuantEstoque = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lblEstoqueAtualizado);
            this.panel1.Controls.Add(this.lblQuantidadeAtualizada);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtQuantEstoque);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 252);
            this.panel1.TabIndex = 0;
            // 
            // lblEstoqueAtualizado
            // 
            this.lblEstoqueAtualizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstoqueAtualizado.Location = new System.Drawing.Point(207, 159);
            this.lblEstoqueAtualizado.Name = "lblEstoqueAtualizado";
            this.lblEstoqueAtualizado.Size = new System.Drawing.Size(245, 36);
            this.lblEstoqueAtualizado.TabIndex = 4;
            // 
            // lblQuantidadeAtualizada
            // 
            this.lblQuantidadeAtualizada.AutoSize = true;
            this.lblQuantidadeAtualizada.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeAtualizada.Location = new System.Drawing.Point(33, 76);
            this.lblQuantidadeAtualizada.Name = "lblQuantidadeAtualizada";
            this.lblQuantidadeAtualizada.Size = new System.Drawing.Size(353, 23);
            this.lblQuantidadeAtualizada.TabIndex = 3;
            this.lblQuantidadeAtualizada.Text = "Quantidade do estoque atualizado:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Morango",
            "Uva",
            "Laranja",
            "Goiaba"});
            this.comboBox1.Location = new System.Drawing.Point(339, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 31);
            this.comboBox1.TabIndex = 2;
            // 
            // txtQuantEstoque
            // 
            this.txtQuantEstoque.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtQuantEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantEstoque.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantEstoque.Location = new System.Drawing.Point(392, 69);
            this.txtQuantEstoque.Name = "txtQuantEstoque";
            this.txtQuantEstoque.Size = new System.Drawing.Size(185, 30);
            this.txtQuantEstoque.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(33, 29);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(300, 23);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Selecione o produto desejado:";
            // 
            // frmGerenciadorEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 252);
            this.Controls.Add(this.panel1);
            this.Name = "frmGerenciadorEstoque";
            this.Text = "Gerenciador de Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantEstoque;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblQuantidadeAtualizada;
        private System.Windows.Forms.Label lblEstoqueAtualizado;
    }
}

