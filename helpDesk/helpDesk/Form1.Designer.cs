namespace helpDesk
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosDeChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarChamadosEncerradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.cadastroToolStripMenuItem.Text = "CADASTRO";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // chamadoToolStripMenuItem
            // 
            this.chamadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem,
            this.visualizarChamadosToolStripMenuItem,
            this.encerrarChamadoToolStripMenuItem,
            this.visualizarChamadosEncerradosToolStripMenuItem});
            this.chamadoToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chamadoToolStripMenuItem.Name = "chamadoToolStripMenuItem";
            this.chamadoToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.chamadoToolStripMenuItem.Text = "CHAMADO";
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirChamadoToolStripMenuItem.Image")));
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            this.abrirChamadoToolStripMenuItem.Size = new System.Drawing.Size(325, 24);
            this.abrirChamadoToolStripMenuItem.Text = "Abrir Chamado";
            this.abrirChamadoToolStripMenuItem.Click += new System.EventHandler(this.abrirChamadoToolStripMenuItem_Click);
            // 
            // visualizarChamadosToolStripMenuItem
            // 
            this.visualizarChamadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarChamadosToolStripMenuItem.Image")));
            this.visualizarChamadosToolStripMenuItem.Name = "visualizarChamadosToolStripMenuItem";
            this.visualizarChamadosToolStripMenuItem.Size = new System.Drawing.Size(325, 24);
            this.visualizarChamadosToolStripMenuItem.Text = "Visualizar chamados";
            this.visualizarChamadosToolStripMenuItem.Click += new System.EventHandler(this.visualizarChamadosToolStripMenuItem_Click);
            // 
            // encerrarChamadoToolStripMenuItem
            // 
            this.encerrarChamadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("encerrarChamadoToolStripMenuItem.Image")));
            this.encerrarChamadoToolStripMenuItem.Name = "encerrarChamadoToolStripMenuItem";
            this.encerrarChamadoToolStripMenuItem.Size = new System.Drawing.Size(325, 24);
            this.encerrarChamadoToolStripMenuItem.Text = "Encerrar Chamado";
            this.encerrarChamadoToolStripMenuItem.Click += new System.EventHandler(this.encerrarChamadoToolStripMenuItem_Click);
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosDeChamadosToolStripMenuItem});
            this.rELATÓRIOSToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // relatoriosDeChamadosToolStripMenuItem
            // 
            this.relatoriosDeChamadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatoriosDeChamadosToolStripMenuItem.Image")));
            this.relatoriosDeChamadosToolStripMenuItem.Name = "relatoriosDeChamadosToolStripMenuItem";
            this.relatoriosDeChamadosToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.relatoriosDeChamadosToolStripMenuItem.Text = "Relatorios de chamados";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.desenvolvedorToolStripMenuItem});
            this.sOBREToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.sOBREToolStripMenuItem.Text = "SOBRE";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("softwareToolStripMenuItem.Image")));
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // desenvolvedorToolStripMenuItem
            // 
            this.desenvolvedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("desenvolvedorToolStripMenuItem.Image")));
            this.desenvolvedorToolStripMenuItem.Name = "desenvolvedorToolStripMenuItem";
            this.desenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.desenvolvedorToolStripMenuItem.Text = "Desenvolvedor";
            this.desenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.desenvolvedorToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.chamadoToolStripMenuItem,
            this.rELATÓRIOSToolStripMenuItem,
            this.sOBREToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarChamadosEncerradosToolStripMenuItem
            // 
            this.visualizarChamadosEncerradosToolStripMenuItem.Name = "visualizarChamadosEncerradosToolStripMenuItem";
            this.visualizarChamadosEncerradosToolStripMenuItem.Size = new System.Drawing.Size(325, 24);
            this.visualizarChamadosEncerradosToolStripMenuItem.Text = "Visualizar chamados encerrados";
            this.visualizarChamadosEncerradosToolStripMenuItem.Click += new System.EventHandler(this.visualizarChamadosEncerradosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "HELP MAIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosDeChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encerrarChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarChamadosEncerradosToolStripMenuItem;
    }
}

