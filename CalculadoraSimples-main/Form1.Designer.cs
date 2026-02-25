namespace calculadora
{
    partial class frmCalculadora
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMaisOuMenos = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnIgualdade = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLinha = new System.Windows.Forms.Label();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.txtDisplay.Location = new System.Drawing.Point(39, 161);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(492, 68);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(54, 255);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 84);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(147, 255);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 84);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(241, 255);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 84);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(54, 345);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 84);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(147, 345);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 84);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(241, 345);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 84);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(55, 435);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(86, 84);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(147, 435);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 84);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(241, 435);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 84);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMaisOuMenos
            // 
            this.btnMaisOuMenos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMaisOuMenos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaisOuMenos.FlatAppearance.BorderSize = 0;
            this.btnMaisOuMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisOuMenos.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.btnMaisOuMenos.Location = new System.Drawing.Point(55, 525);
            this.btnMaisOuMenos.Name = "btnMaisOuMenos";
            this.btnMaisOuMenos.Size = new System.Drawing.Size(86, 84);
            this.btnMaisOuMenos.TabIndex = 10;
            this.btnMaisOuMenos.Text = "+/-";
            this.btnMaisOuMenos.UseVisualStyleBackColor = false;
            this.btnMaisOuMenos.Click += new System.EventHandler(this.btnMaisOuMenos_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(147, 525);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 84);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.LightCyan;
            this.btnPonto.FlatAppearance.BorderSize = 0;
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonto.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnPonto.Location = new System.Drawing.Point(431, 435);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(89, 84);
            this.btnPonto.TabIndex = 12;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnIgualdade
            // 
            this.btnIgualdade.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIgualdade.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIgualdade.FlatAppearance.BorderSize = 0;
            this.btnIgualdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgualdade.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnIgualdade.Location = new System.Drawing.Point(336, 525);
            this.btnIgualdade.Name = "btnIgualdade";
            this.btnIgualdade.Size = new System.Drawing.Size(184, 84);
            this.btnIgualdade.TabIndex = 13;
            this.btnIgualdade.Text = "=";
            this.btnIgualdade.UseVisualStyleBackColor = false;
            this.btnIgualdade.Click += new System.EventHandler(this.btnIgualdade_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.LightCyan;
            this.btnPorcentagem.FlatAppearance.BorderSize = 0;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentagem.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnPorcentagem.Location = new System.Drawing.Point(336, 435);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(89, 84);
            this.btnPorcentagem.TabIndex = 15;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.LightCyan;
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnSubtrair.Location = new System.Drawing.Point(431, 345);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(89, 84);
            this.btnSubtrair.TabIndex = 16;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.LightCyan;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnDividir.Location = new System.Drawing.Point(431, 255);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(89, 84);
            this.btnDividir.TabIndex = 17;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnDeletar.Location = new System.Drawing.Point(241, 525);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 84);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "AC";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.LightCyan;
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnSomar.Location = new System.Drawing.Point(336, 345);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(89, 84);
            this.btnSomar.TabIndex = 19;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.LightCyan;
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnMultiplicar.Location = new System.Drawing.Point(336, 255);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(89, 84);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLinha
            // 
            this.btnLinha.AutoSize = true;
            this.btnLinha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinha.Location = new System.Drawing.Point(-272, 68);
            this.btnLinha.Name = "btnLinha";
            this.btnLinha.Size = new System.Drawing.Size(2, 24);
            this.btnLinha.TabIndex = 21;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.lblCalculadora.Location = new System.Drawing.Point(81, 26);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(409, 72);
            this.lblCalculadora.TabIndex = 22;
            this.lblCalculadora.Text = "CALCULADORA";
            // 
            // lblConta
            // 
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(48, 112);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(174, 36);
            this.lblConta.TabIndex = 23;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(563, 661);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.btnLinha);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnIgualdade);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMaisOuMenos);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMaisOuMenos;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnIgualdade;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label btnLinha;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblConta;
    }
}

