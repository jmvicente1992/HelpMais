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
    public partial class encerrarChamado : Form
    {
        MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_helpDesk;Uid=root;Pwd=usbw;SslMode=none");
        MySqlCommand comando = new MySqlCommand();
        MySqlCommand pesquisa = new MySqlCommand();
        
        public encerrarChamado()
        {
            InitializeComponent();
            cbbStatus.SelectedIndex = 2;
        }

        private void encerrarChamado_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

        }

        public void FecharChamado()
        {
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FecharChamado();
        }
    }
}
