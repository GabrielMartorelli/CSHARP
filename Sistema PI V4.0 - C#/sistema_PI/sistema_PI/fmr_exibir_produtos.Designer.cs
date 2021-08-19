namespace sitema_PI
{
    partial class fmr_exibir_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_exibir_produtos));
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.btn_editar_prod = new System.Windows.Forms.Button();
            this.btn_excluir_prod = new System.Windows.Forms.Button();
            this.tb_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 12);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(776, 365);
            this.dgv_produtos.TabIndex = 0;
            // 
            // btn_editar_prod
            // 
            this.btn_editar_prod.BackColor = System.Drawing.Color.Cyan;
            this.btn_editar_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_editar_prod.Location = new System.Drawing.Point(12, 383);
            this.btn_editar_prod.Name = "btn_editar_prod";
            this.btn_editar_prod.Size = new System.Drawing.Size(97, 37);
            this.btn_editar_prod.TabIndex = 1;
            this.btn_editar_prod.Text = "Editar";
            this.btn_editar_prod.UseVisualStyleBackColor = false;
            this.btn_editar_prod.Click += new System.EventHandler(this.btn_editar_prod_Click);
            // 
            // btn_excluir_prod
            // 
            this.btn_excluir_prod.BackColor = System.Drawing.Color.Red;
            this.btn_excluir_prod.ForeColor = System.Drawing.Color.White;
            this.btn_excluir_prod.Location = new System.Drawing.Point(115, 383);
            this.btn_excluir_prod.Name = "btn_excluir_prod";
            this.btn_excluir_prod.Size = new System.Drawing.Size(97, 37);
            this.btn_excluir_prod.TabIndex = 2;
            this.btn_excluir_prod.Text = "Excluir";
            this.btn_excluir_prod.UseVisualStyleBackColor = false;
            this.btn_excluir_prod.Click += new System.EventHandler(this.btn_excluir_prod_Click);
            // 
            // tb_menu
            // 
            this.tb_menu.BackColor = System.Drawing.Color.SpringGreen;
            this.tb_menu.Location = new System.Drawing.Point(691, 383);
            this.tb_menu.Name = "tb_menu";
            this.tb_menu.Size = new System.Drawing.Size(97, 37);
            this.tb_menu.TabIndex = 3;
            this.tb_menu.Text = "Menu";
            this.tb_menu.UseVisualStyleBackColor = false;
            this.tb_menu.Click += new System.EventHandler(this.tb_menu_Click);
            // 
            // fmr_exibir_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_menu);
            this.Controls.Add(this.btn_excluir_prod);
            this.Controls.Add(this.btn_editar_prod);
            this.Controls.Add(this.dgv_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_exibir_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Button btn_editar_prod;
        private System.Windows.Forms.Button btn_excluir_prod;
        private System.Windows.Forms.Button tb_menu;
    }
}