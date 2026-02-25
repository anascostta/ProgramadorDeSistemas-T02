namespace simpleCalculator
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnMaisouMenos = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(24, 27);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(276, 90);
            this.txtDisplay.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(24, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(276, 50);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1.Location = new System.Drawing.Point(24, 179);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 55);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.Location = new System.Drawing.Point(95, 179);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 55);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.Location = new System.Drawing.Point(167, 179);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 55);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(237, 179);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(63, 55);
            this.btnSoma.TabIndex = 28;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(237, 240);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(63, 55);
            this.btnMultiplicacao.TabIndex = 29;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMaisouMenos
            // 
            this.btnMaisouMenos.Location = new System.Drawing.Point(98, 362);
            this.btnMaisouMenos.Name = "btnMaisouMenos";
            this.btnMaisouMenos.Size = new System.Drawing.Size(62, 55);
            this.btnMaisouMenos.TabIndex = 30;
            this.btnMaisouMenos.Text = "+/-";
            this.btnMaisouMenos.UseVisualStyleBackColor = true;
            this.btnMaisouMenos.Click += new System.EventHandler(this.btnMaisouMenos_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(238, 362);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(62, 55);
            this.btnDivisao.TabIndex = 31;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Thistle;
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Location = new System.Drawing.Point(24, 423);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(276, 58);
            this.btnResultado.TabIndex = 32;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(166, 362);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(63, 55);
            this.btnPorcentagem.TabIndex = 33;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(237, 301);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(63, 55);
            this.btnSubtracao.TabIndex = 34;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn0.Location = new System.Drawing.Point(24, 362);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 55);
            this.btn0.TabIndex = 35;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn7.Location = new System.Drawing.Point(24, 301);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 55);
            this.btn7.TabIndex = 36;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn4.Location = new System.Drawing.Point(24, 240);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 55);
            this.btn4.TabIndex = 37;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn5.Location = new System.Drawing.Point(95, 240);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 55);
            this.btn5.TabIndex = 38;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn8.Location = new System.Drawing.Point(95, 301);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 55);
            this.btn8.TabIndex = 39;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn6.Location = new System.Drawing.Point(164, 240);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 55);
            this.btn6.TabIndex = 40;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn9.Location = new System.Drawing.Point(164, 301);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 55);
            this.btn9.TabIndex = 41;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(323, 505);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMaisouMenos);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnMaisouMenos;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
    }
}

