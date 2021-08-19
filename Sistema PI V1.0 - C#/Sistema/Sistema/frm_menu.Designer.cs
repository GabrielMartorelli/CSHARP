
namespace Sistema
{
    partial class frm_menu
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
            this.btn_ajuda2 = new System.Windows.Forms.Button();
            this.btn_ajuda3 = new System.Windows.Forms.Button();
            this.btn_ajuda1 = new System.Windows.Forms.Button();
            this.btn_ajuda4 = new System.Windows.Forms.Button();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ajuda = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_ajuda2
            // 
            this.btn_ajuda2.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda2.Location = new System.Drawing.Point(144, 99);
            this.btn_ajuda2.Name = "btn_ajuda2";
            this.btn_ajuda2.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda2.TabIndex = 2;
            this.btn_ajuda2.Text = "ajuda2";
            this.btn_ajuda2.UseVisualStyleBackColor = false;
            this.btn_ajuda2.Click += new System.EventHandler(this.btn_cad_produtos_Click);
            // 
            // btn_ajuda3
            // 
            this.btn_ajuda3.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda3.Location = new System.Drawing.Point(275, 99);
            this.btn_ajuda3.Name = "btn_ajuda3";
            this.btn_ajuda3.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda3.TabIndex = 3;
            this.btn_ajuda3.Text = "ajuda3";
            this.btn_ajuda3.UseVisualStyleBackColor = false;
            this.btn_ajuda3.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // btn_ajuda1
            // 
            this.btn_ajuda1.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda1.Location = new System.Drawing.Point(15, 99);
            this.btn_ajuda1.Name = "btn_ajuda1";
            this.btn_ajuda1.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda1.TabIndex = 6;
            this.btn_ajuda1.Text = "ajuda1";
            this.btn_ajuda1.UseVisualStyleBackColor = false;
            this.btn_ajuda1.Click += new System.EventHandler(this.btn_criar_venda_Click);
            // 
            // btn_ajuda4
            // 
            this.btn_ajuda4.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda4.Location = new System.Drawing.Point(12, 215);
            this.btn_ajuda4.Name = "btn_ajuda4";
            this.btn_ajuda4.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda4.TabIndex = 7;
            this.btn_ajuda4.Text = "ajuda4";
            this.btn_ajuda4.UseVisualStyleBackColor = false;
            this.btn_ajuda4.Click += new System.EventHandler(this.btn_con_vendas_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // lbl_ajuda
            // 
            this.lbl_ajuda.AutoSize = true;
            this.lbl_ajuda.Location = new System.Drawing.Point(161, 24);
            this.lbl_ajuda.Name = "lbl_ajuda";
            this.lbl_ajuda.Size = new System.Drawing.Size(171, 13);
            this.lbl_ajuda.TabIndex = 8;
            this.lbl_ajuda.Text = "Nosso Sitema de Ajuda ao Usuário";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(23, 69);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(249, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Clique na Categoria abaixo que Necessita de Ajuda";
            // 
            // btn_ajuda5
            // 
            this.btn_ajuda5.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda5.Location = new System.Drawing.Point(144, 215);
            this.btn_ajuda5.Name = "btn_ajuda5";
            this.btn_ajuda5.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda5.TabIndex = 10;
            this.btn_ajuda5.Text = "ajuda5";
            this.btn_ajuda5.UseVisualStyleBackColor = false;
            // 
            // btn_ajuda6
            // 
            this.btn_ajuda6.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuda6.Location = new System.Drawing.Point(275, 215);
            this.btn_ajuda6.Name = "btn_ajuda6";
            this.btn_ajuda6.Size = new System.Drawing.Size(108, 48);
            this.btn_ajuda6.TabIndex = 11;
            this.btn_ajuda6.Text = "ajuda6";
            this.btn_ajuda6.UseVisualStyleBackColor = false;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 315);
            this.Controls.Add(this.btn_ajuda6);
            this.Controls.Add(this.btn_ajuda5);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_ajuda);
            this.Controls.Add(this.btn_ajuda4);
            this.Controls.Add(this.btn_ajuda1);
            this.Controls.Add(this.btn_ajuda3);
            this.Controls.Add(this.btn_ajuda2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_ajuda2;
        private System.Windows.Forms.Button btn_ajuda3;
        private System.Windows.Forms.Button btn_ajuda1;
        private System.Windows.Forms.Button btn_ajuda4;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_ajuda;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_ajuda5;
        private System.Windows.Forms.Button btn_ajuda6;
    }
}

