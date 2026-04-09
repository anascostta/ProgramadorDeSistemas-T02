using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Acessando o pacote do MySQL
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class frmCadastroDeCliente : Form
    {

        // Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        public frmCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validando campos obrigatórios
                if(string.IsNullOrEmpty(txtNomeCompleto.Text.Trim())||
                   string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                   string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", 
                                    "Validação",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se algum campo estiver vazio
                }

                // Validação do CPF
                string cpf = txtCPF.Text.Trim();
                if (!IsValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 digitos númericos.",
                        "Validação do CPF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se algum campo estiver vazio
                }

                // Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados 
                MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = Conexao
                    };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " +
                    "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                // Adiciona os parâmetros com os dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());


                // Executa o comando de inserção no banco de dados
                cmd.ExecuteNonQuery();

                // Mensagem de sucesso
                MessageBox.Show("Contato inserido com sucesso: ", 
                                "Sucesso",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                // Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                // Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message, 
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // Garante que a conexão com o banco será fechada, mesmo se ocorrer erros
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        // Função para validar o comprimento e formato do CPF
        private bool IsValidCPFLength(string cpf)
        {
            // Remove todos os caracteres não númericos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos
            return cpf.Length == 11;
        }
    }
}
