namespace sitema_PI
{
    partial class fmr_editar_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_editar_produtos));
            this.btn_cadastrar_prod = new System.Windows.Forms.Button();
            this.tbx_status_prod = new System.Windows.Forms.TextBox();
            this.tbx_periodo_prod = new System.Windows.Forms.TextBox();
            this.tbx_categoria_prod = new System.Windows.Forms.TextBox();
            this.tbx_valor_prod = new System.Windows.Forms.TextBox();
            this.tbx_nome_prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastrar_prod
            // 
            this.btn_cadastrar_prod.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_cadastrar_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrar_prod.Location = new System.Drawing.Point(452, 71);
            this.btn_cadastrar_prod.Name = "btn_cadastrar_prod";
            this.btn_cadastrar_prod.Size = new System.Drawing.Size(149, 77);
            this.btn_cadastrar_prod.TabIndex = 25;
            this.btn_cadastrar_prod.Text = "Salvar alteração";
            this.btn_cadastrar_prod.UseVisualStyleBackColor = false;
            this.btn_cadastrar_prod.Click += new System.EventHandler(this.btn_cadastrar_prod_Click);
            // 
            // tbx_status_prod
            // 
            this.tbx_status_prod.Location = new System.Drawing.Point(75, 176);
            this.tbx_status_prod.Name = "tbx_status_prod";
            this.tbx_status_prod.Size = new System.Drawing.Size(302, 20);
            this.tbx_status_prod.TabIndex = 24;
            // 
            // tbx_periodo_prod
            // 
            this.tbx_periodo_prod.Location = new System.Drawing.Point(75, 132);
            this.tbx_periodo_prod.Name = "tbx_periodo_prod";
            this.tbx_periodo_prod.Size = new System.Drawing.Size(302, 20);
            this.tbx_periodo_prod.TabIndex = 23;
            // 
            // tbx_categoria_prod
            // 
            this.tbx_categoria_prod.Location = new System.Drawing.Point(75, 92);
            this.tbx_categoria_prod.Name = "tbx_categoria_prod";
            this.tbx_categoria_prod.Size = new System.Drawing.Size(302, 20);
            this.tbx_categoria_prod.TabIndex = 21;
            // 
            // tbx_valor_prod
            // 
            this.tbx_valor_prod.Location = new System.Drawing.Point(75, 47);
            this.tbx_valor_prod.Name = "tbx_valor_prod";
            this.tbx_valor_prod.Size = new System.Drawing.Size(302, 20);
            this.tbx_valor_prod.TabIndex = 20;
            // 
            // tbx_nome_prod
            // 
            this.tbx_nome_prod.Location = new System.Drawing.Point(75, 12);
            this.tbx_nome_prod.Name = "tbx_nome_prod";
            this.tbx_nome_prod.Size = new System.Drawing.Size(302, 20);
            this.tbx_nome_prod.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // fmr_editar_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cadastrar_prod);
            this.Controls.Add(this.tbx_status_prod);
            this.Controls.Add(this.tbx_periodo_prod);
            this.Controls.Add(this.tbx_categoria_prod);
            this.Controls.Add(this.tbx_valor_prod);
            this.Controls.Add(this.tbx_nome_prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_editar_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_editar_produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar_prod;
        private System.Windows.Forms.TextBox tbx_status_prod;
        private System.Windows.Forms.TextBox tbx_periodo_prod;
        private System.Windows.Forms.TextBox tbx_categoria_prod;
        private System.Windows.Forms.TextBox tbx_valor_prod;
        private System.Windows.Forms.TextBox tbx_nome_prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}