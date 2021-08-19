namespace sistema_estoque
{
    partial class fmr_ajuda
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_alunos = new System.Windows.Forms.Button();
            this.btn_cursos = new System.Windows.Forms.Button();
            this.btn_login_menu = new System.Windows.Forms.Button();
            this.btn_prod_prof = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de ajuda ao usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clique na categoria que necessita ajuda ";
            // 
            // btn_alunos
            // 
            this.btn_alunos.Location = new System.Drawing.Point(28, 97);
            this.btn_alunos.Name = "btn_alunos";
            this.btn_alunos.Size = new System.Drawing.Size(101, 41);
            this.btn_alunos.TabIndex = 3;
            this.btn_alunos.Text = "Alunos";
            this.btn_alunos.UseVisualStyleBackColor = true;
            this.btn_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // btn_cursos
            // 
            this.btn_cursos.Location = new System.Drawing.Point(298, 97);
            this.btn_cursos.Name = "btn_cursos";
            this.btn_cursos.Size = new System.Drawing.Size(101, 41);
            this.btn_cursos.TabIndex = 5;
            this.btn_cursos.Text = "Venda de Cursos";
            this.btn_cursos.UseVisualStyleBackColor = true;
            this.btn_cursos.Click += new System.EventHandler(this.btn_cursos_Click);
            // 
            // btn_login_menu
            // 
            this.btn_login_menu.Location = new System.Drawing.Point(435, 97);
            this.btn_login_menu.Name = "btn_login_menu";
            this.btn_login_menu.Size = new System.Drawing.Size(101, 41);
            this.btn_login_menu.TabIndex = 6;
            this.btn_login_menu.Text = "Login e Menu";
            this.btn_login_menu.UseVisualStyleBackColor = true;
            this.btn_login_menu.Click += new System.EventHandler(this.btn_login_menu_Click);
            // 
            // btn_prod_prof
            // 
            this.btn_prod_prof.Location = new System.Drawing.Point(567, 97);
            this.btn_prod_prof.Name = "btn_prod_prof";
            this.btn_prod_prof.Size = new System.Drawing.Size(101, 41);
            this.btn_prod_prof.TabIndex = 7;
            this.btn_prod_prof.Text = "Produtos";
            this.btn_prod_prof.UseVisualStyleBackColor = true;
            this.btn_prod_prof.Click += new System.EventHandler(this.btn_prod_prof_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Location = new System.Drawing.Point(160, 97);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(101, 41);
            this.btn_vendas.TabIndex = 8;
            this.btn_vendas.Text = "Vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // fmr_ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 199);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_prod_prof);
            this.Controls.Add(this.btn_login_menu);
            this.Controls.Add(this.btn_cursos);
            this.Controls.Add(this.btn_alunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmr_ajuda";
            this.Text = "fmr_ajuda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_alunos;
        private System.Windows.Forms.Button btn_cursos;
        private System.Windows.Forms.Button btn_login_menu;
        private System.Windows.Forms.Button btn_prod_prof;
        private System.Windows.Forms.Button btn_vendas;
    }
}