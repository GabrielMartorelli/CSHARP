namespace sitema_PI
{
    partial class fmr_cursos_disponiveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_cursos_disponiveis));
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar_aluno = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vendas
            // 
            this.dgv_vendas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendas.Location = new System.Drawing.Point(12, 12);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.Size = new System.Drawing.Size(776, 361);
            this.dgv_vendas.TabIndex = 0;
            // 
            // btn_cadastrar_aluno
            // 
            this.btn_cadastrar_aluno.BackColor = System.Drawing.Color.Cyan;
            this.btn_cadastrar_aluno.Location = new System.Drawing.Point(12, 379);
            this.btn_cadastrar_aluno.Name = "btn_cadastrar_aluno";
            this.btn_cadastrar_aluno.Size = new System.Drawing.Size(111, 41);
            this.btn_cadastrar_aluno.TabIndex = 1;
            this.btn_cadastrar_aluno.Text = "Cadastrar Venda";
            this.btn_cadastrar_aluno.UseVisualStyleBackColor = false;
            this.btn_cadastrar_aluno.Click += new System.EventHandler(this.btn_cadastrar_aluno_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_voltar.ForeColor = System.Drawing.Color.Black;
            this.btn_voltar.Location = new System.Drawing.Point(677, 379);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(111, 41);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // fmr_cursos_disponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar_aluno);
            this.Controls.Add(this.dgv_vendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_cursos_disponiveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_cursos_disponiveis";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.Button btn_cadastrar_aluno;
        private System.Windows.Forms.Button btn_voltar;
    }
}