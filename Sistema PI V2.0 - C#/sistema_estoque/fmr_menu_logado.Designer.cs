namespace sistema_estoque
{
    partial class fmr_menu_logado
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
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_produto
            // 
            this.btn_produto.Location = new System.Drawing.Point(134, 123);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(108, 48);
            this.btn_produto.TabIndex = 0;
            this.btn_produto.Text = "Criar Produto";
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(12, 261);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(75, 23);
            this.btn_log_out.TabIndex = 1;
            this.btn_log_out.Text = "sair";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // fmr_menu_logado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 296);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_produto);
            this.Name = "fmr_menu_logado";
            this.Text = "fmr_menu_logado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_log_out;
    }
}