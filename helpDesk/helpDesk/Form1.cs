using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirChamado abrirChamado = new AbrirChamado();
            abrirChamado.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("DESEJA SAIR DO SISTEMA ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visualizarChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizaChamado visualiza = new VisualizaChamado();
            visualiza.Show();
        }

        private void encerrarChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encerrarChamado encerrar = new encerrarChamado();
            encerrar.Show();
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desenvolvedor desenvolvedor = new Desenvolvedor();
            desenvolvedor.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA SAIR DO SISTEMA ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)

            {
                e.Cancel = true;
            }
        }

        private void visualizarChamadosEncerradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visuChamadoFechados visu = new visuChamadoFechados();
            visu.Show();
        }
    }
}
