using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace helpDesk
{
    
    public partial class Login : Form
    {

        MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_helpDesk;Uid=root;Pwd=usbw;SslMode=none");
        MySqlCommand comando = new MySqlCommand();
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login();
        }

        // Código para conexão com verificação de usuario e senha. usando COUNT
        public void login()
        {
            conexao.Open();
            comando.Connection = conexao;

            try
            {
                comando.CommandText = "select count(*) from tb_login where usuario ='" + txtUsuario.Text + "' and senha='" + txtSenha.Text + "'";
                int valor = int.Parse(comando.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    MessageBox.Show("CONECTADO COM SUCESSO","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETOS", "ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro"+ex);
            }
            conexao.Close();           
        }
    }
}
