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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtSetor.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salvar()
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo NOME COMPLETO", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.Red;
            }
            MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_helpDesk;Uid=root;Pwd=usbw;SslMode=none");
            conexao.Open();
            MySqlCommand comando;

            if (txtId.Text == String.Empty)
            {
                comando = new MySqlCommand("INSERT INTO tb_login(ID, NOME, NASCIMENTO, CPF, SETOR, USUARIO, SENHA)" + "VALUES('" + txtId.Text + "','" + txtNome.Text + "','" + dtpNascimento.Text + "','" + txtCpf.Text + "', '" + txtSetor.Text + "', '" + txtUsuario.Text + "', '" + txtSenha.Text + "');", conexao);
                MessageBox.Show("SALVO COM SUCESSO", "ATENÇÃO");
            }
            else
            {
                comando = new MySqlCommand("Update data SET NOME='" + txtNome.Text + "',NASCIMENTO='" + dtpNascimento.Text + "',CPF='" + txtCpf.Text + "', SETOR='" + txtUsuario.Text + "', SENHA='" + txtSenha.Text + "'WHERE ID='" + txtId.Text + "'", conexao);

            }
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
