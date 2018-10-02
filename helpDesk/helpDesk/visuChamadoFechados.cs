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

namespace helpDesk
{
    public partial class visuChamadoFechados : Form
    {
        public visuChamadoFechados()
        {
            InitializeComponent();
        }

        private void visuChamadoFechados_Load(object sender, EventArgs e)
        {

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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisar(txtPesquisa.Text);
        }
    }
}
