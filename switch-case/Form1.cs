using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var codigo = Convert.ToInt16(txtCodigoInserido.Text); //transforma o codigo em um int16
                lblDescricao.Text = GetTipoCombustivel(codigo); // aciona o metodo, pega o result e escreve no lblDescricao
            }

            catch (Exception ex) //se houver um erro dispara a mensagem falha mais o codigo do erro
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }
        
        private string GetTipoCombustivel(int codigo)
        {
            var result = ""; //variavel começa vazia, se o usuario nao mandar nada nao vai retornar nada, se mandar cai no witch

            switch (codigo)
            {
                case 1:
                    result = "Gasolina"; //se selecionar 1 result sera igual a gasolina
                    break;

                case 2:
                    result = "Álcool";
                    break;

                case 3:
                    result = "Flex";
                    break;

                case 4:
                    result = "Gás GNV";
                    break;

                case 5:
                    result = "Diesel";
                    break;

                case 6:
                    result = "Eletrecidade";
                    break;

                default:
                    result = "Inválido";
                    break;
            }
             return result; // vai retornar a variavel result, ou seja o q foi escrito la
        }
    }
}
