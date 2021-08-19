
namespace Ajuda
{
    partial class frm_ajuda
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ajuda = new System.Windows.Forms.Label();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.btn_ajuda1 = new System.Windows.Forms.Button();
            this.btn_ajuda2 = new System.Windows.Forms.Button();
            this.btn_ajuda3 = new System.Windows.Forms.Button();
            this.btn_ajuda4 = new System.Windows.Forms.Button();
            this.btn_ajuda5 = new System.Windows.Forms.Button();
            this.btn_ajuda6 = new System.Windows.Forms.Button();
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
            // lbl_ajuda
            // 
            this.lbl_ajuda.AutoSize = true;
            this.lbl_ajuda.Location = new System.Drawing.Point(267, 11);
            this.lbl_ajuda.Name = "lbl_ajuda";
            this.lbl_ajuda.Size = new System.Drawing.Size(174, 13);
            this.lbl_ajuda.TabIndex = 1;
            this.lbl_ajuda.Text = "Nosso Sitema de Ajuda ao Usuário:";
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Location = new System.Drawing.Point(243, 53);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(218, 13);
            this.lbl_categorias.TabIndex = 2;
            this.lbl_categorias.Text = "Clique na Categoria que Necessita de Ajuda:";
            // 
            // btn_ajuda1
            // 
            this.btn_ajuda1.Location = new System.Drawing.Point(28, 97);
            this.btn_ajuda1.Name = "btn_ajuda1";
            this.btn_ajuda1.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda1.TabIndex = 3;
            this.btn_ajuda1.Text = "Alunos";
            this.btn_ajuda1.UseVisualStyleBackColor = true;
            this.btn_ajuda1.Click += new System.EventHandler(this.btn_ajuda1_Click);
            // 
            // btn_ajuda2
            // 
            this.btn_ajuda2.Location = new System.Drawing.Point(162, 97);
            this.btn_ajuda2.Name = "btn_ajuda2";
            this.btn_ajuda2.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda2.TabIndex = 4;
            this.btn_ajuda2.Text = "Categorias";
            this.btn_ajuda2.UseVisualStyleBackColor = true;
            this.btn_ajuda2.Click += new System.EventHandler(this.btn_ajuda2_Click);
            // 
            // btn_ajuda3
            // 
            this.btn_ajuda3.Location = new System.Drawing.Point(298, 97);
            this.btn_ajuda3.Name = "btn_ajuda3";
            this.btn_ajuda3.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda3.TabIndex = 5;
            this.btn_ajuda3.Text = "Cursos";
            this.btn_ajuda3.UseVisualStyleBackColor = true;
            this.btn_ajuda3.Click += new System.EventHandler(this.btn_ajuda3_Click);
            // 
            // btn_ajuda4
            // 
            this.btn_ajuda4.Location = new System.Drawing.Point(435, 97);
            this.btn_ajuda4.Name = "btn_ajuda4";
            this.btn_ajuda4.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda4.TabIndex = 6;
            this.btn_ajuda4.Text = "Login e Menu";
            this.btn_ajuda4.UseVisualStyleBackColor = true;
            this.btn_ajuda4.Click += new System.EventHandler(this.btn_ajuda4_Click);
            // 
            // btn_ajuda5
            // 
            this.btn_ajuda5.Location = new System.Drawing.Point(567, 97);
            this.btn_ajuda5.Name = "btn_ajuda5";
            this.btn_ajuda5.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda5.TabIndex = 7;
            this.btn_ajuda5.Text = "Produtos e Professores";
            this.btn_ajuda5.UseVisualStyleBackColor = true;
            this.btn_ajuda5.Click += new System.EventHandler(this.btn_ajuda5_Click);
            // 
            // btn_ajuda6
            // 
            this.btn_ajuda6.Location = new System.Drawing.Point(298, 156);
            this.btn_ajuda6.Name = "btn_ajuda6";
            this.btn_ajuda6.Size = new System.Drawing.Size(101, 41);
            this.btn_ajuda6.TabIndex = 8;
            this.btn_ajuda6.Text = "Vendas";
            this.btn_ajuda6.UseVisualStyleBackColor = true;
            this.btn_ajuda6.Click += new System.EventHandler(this.btn_ajuda6_Click);
            // 
            // frm_ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 199);
            this.Controls.Add(this.btn_ajuda6);
            this.Controls.Add(this.btn_ajuda5);
            this.Controls.Add(this.btn_ajuda4);
            this.Controls.Add(this.btn_ajuda3);
            this.Controls.Add(this.btn_ajuda2);
            this.Controls.Add(this.btn_ajuda1);
            this.Controls.Add(this.lbl_categorias);
            this.Controls.Add(this.lbl_ajuda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ajuda";
            this.Text = "Ajuda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_ajuda;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.Button btn_ajuda1;
        private System.Windows.Forms.Button btn_ajuda2;
        private System.Windows.Forms.Button btn_ajuda3;
        private System.Windows.Forms.Button btn_ajuda4;
        private System.Windows.Forms.Button btn_ajuda5;
        private System.Windows.Forms.Button btn_ajuda6;
    }
}

