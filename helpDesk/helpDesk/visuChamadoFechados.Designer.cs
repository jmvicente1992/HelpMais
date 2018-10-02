namespace helpDesk
{
    partial class visuChamadoFechados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLimpar = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLimpar
            // 
            this.txtLimpar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimpar.Location = new System.Drawing.Point(539, 23);
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(159, 28);
            this.txtLimpar.TabIndex = 6;
            this.txtLimpar.Text = "LIMPAR GRID";
            this.txtLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvView
            // 
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(13, 96);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(775, 332);
            this.dgvView.TabIndex = 5;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(237, 23);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(272, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // visuChamadoFechados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLimpar);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "visuChamadoFechados";
            this.Text = "VISUALIZAR CHAMADOS FECHADOS";
            this.Load += new System.EventHandler(this.visuChamadoFechados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtLimpar;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}