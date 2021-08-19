namespace sistema_estoque
{
    partial class fmr_menu
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
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_cursos = new System.Windows.Forms.Button();
            this.btn_professores = new System.Windows.Forms.Button();
            this.btn_alunos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_venda
            // 
            this.btn_venda.Location = new System.Drawing.Point(135, 102);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(108, 48);
            this.btn_venda.TabIndex = 0;
            this.btn_venda.Text = "Consultar Venda";
            this.btn_venda.UseVisualStyleBackColor = true;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_cursos
            // 
            this.btn_cursos.Location = new System.Drawing.Point(285, 102);
            this.btn_cursos.Name = "btn_cursos";
            this.btn_cursos.Size = new System.Drawing.Size(108, 48);
            this.btn_cursos.TabIndex = 1;
            this.btn_cursos.Text = "Consultar Cursos";
            this.btn_cursos.UseVisualStyleBackColor = true;
            this.btn_cursos.Click += new System.EventHandler(this.btn_cursos_Click);
            // 
            // btn_professores
            // 
            this.btn_professores.Location = new System.Drawing.Point(285, 172);
            this.btn_professores.Name = "btn_professores";
            this.btn_professores.Size = new System.Drawing.Size(108, 48);
            this.btn_professores.TabIndex = 2;
            this.btn_professores.Text = "Consultar Professores";
            this.btn_professores.UseVisualStyleBackColor = true;
            this.btn_professores.Click += new System.EventHandler(this.btn_professores_Click);
            // 
            // btn_alunos
            // 
            this.btn_alunos.Location = new System.Drawing.Point(135, 172);
            this.btn_alunos.Name = "btn_alunos";
            this.btn_alunos.Size = new System.Drawing.Size(108, 48);
            this.btn_alunos.TabIndex = 3;
            this.btn_alunos.Text = "Consultar Alunos";
            this.btn_alunos.UseVisualStyleBackColor = true;
            this.btn_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.logarToolStripMenuItem.Text = "Logar";
            this.logarToolStripMenuItem.Click += new System.EventHandler(this.logarToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // fmr_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 354);
            this.Controls.Add(this.btn_alunos);
            this.Controls.Add(this.btn_professores);
            this.Controls.Add(this.btn_cursos);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmr_menu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.Button btn_cursos;
        private System.Windows.Forms.Button btn_professores;
        private System.Windows.Forms.Button btn_alunos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}

