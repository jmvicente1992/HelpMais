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

    public partial class AbrirChamado : Form
    {
        MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_helpDesk;Uid=root;Pwd=usbw;SslMode=none");
        MySqlCommand comando = new MySqlCommand();
        public AbrirChamado()
        {
            InitializeComponent();
            cbbStatus.Text = "Aberto";
            cbbStatus.SelectedIndex = 0;
            cbbTipo.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtRequisitante.Clear();
            txtSetor.Clear();
            txtTitulo.Clear();
            txtDescricao.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AbrirChamado_Load(object sender, EventArgs e)
        {

        }

        private void txtRequisitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSetor_TextChanged(object sender, EventArgs e)
        {

        }

        //METODO DE SALVAR CHAMADO
        public void salvar()
        {
            conexao.Open();

            if (txtId.Text == String.Empty)
            {
                comando = new MySqlCommand("INSERT INTO tb_abrichamado(ID, REQUISITANTE, SETOR, DATAABERTURA, TIPO, TITULO, DESCRICAO, STATUS)" + "VALUES('" + txtId.Text + "','" + txtRequisitante.Text + "','" + txtSetor.Text + "','" + dtpData.Text + "','" + cbbTipo.Text + "','" + txtTitulo.Text + "','" + txtDescricao.Text + "','" + cbbStatus.Text + "');", conexao);
            }
            else
            {
                comando = new MySqlCommand("Update data SET REQUISITANTE='" + txtRequisitante.Text + "', SETOR='" + txtSetor.Text + "', DATAABERTURA='" + dtpData.Text + "', TIPO='" + txtTitulo.Text + "', TITULO='" + txtTitulo.Text + "', DESCRICAO='" + txtDescricao.Text + "', STATUS='" + cbbStatus.Text + "' WHERE ID='" + txtId.Text + "'", conexao);
            }
            comando.ExecuteNonQuery();
            MessageBox.Show("SALVO COM SUCESSO", "ATENÇÃO");
            conexao.Close();

        }

    }

    }



