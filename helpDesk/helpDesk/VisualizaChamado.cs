using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace helpDesk
{
    public partial class VisualizaChamado : Form
    {
        public VisualizaChamado()
        {
            InitializeComponent();
        }


        public void pesquisar(string valueToFind)
        {
            MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_helpDesk;Uid=root;Pwd=usbw;SslMode=none");
            conexao.Open();
            MySqlCommand pesquisa = new MySqlCommand("select id, requisitante, setor, tipo, titulo, descricao, status from tb_abrichamado", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(pesquisa);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvView.DataSource = dt;

            conexao.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pesquisar(txtPesquisa.Text);
            //pesquisar("");
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            dgvView.Columns.Clear();
            txtPesquisa.Clear();
        }

        private void VisualizaChamado_Load(object sender, EventArgs e)
        {

        }
    }
}
