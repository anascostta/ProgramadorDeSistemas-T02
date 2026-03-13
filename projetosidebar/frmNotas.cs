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
    public partial class frmNotas : Form
    {
        string[,] boletim = new string[5, 3];
        int contLinha = 0;
        public frmNotas()
        {
            InitializeComponent();
            dtgMatriz.ColumnCount = 2;
            dtgMatriz.Columns[0].Name = "Disciplina";
            dtgMatriz.Columns[1].Name = "Nota";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
