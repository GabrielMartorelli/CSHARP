namespace sistema_estoque
{
    partial class fmr_professores
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
            this.dgv_professor = new System.Windows.Forms.DataGridView();
            this.tb_proc_prof = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_professor
            // 
            this.dgv_professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professor.Location = new System.Drawing.Point(12, 105);
            this.dgv_professor.Name = "dgv_professor";
            this.dgv_professor.Size = new System.Drawing.Size(776, 333);
            this.dgv_professor.TabIndex = 0;
            // 
            // tb_proc_prof
            // 
            this.tb_proc_prof.Location = new System.Drawing.Point(13, 13);
            this.tb_proc_prof.Name = "tb_proc_prof";
            this.tb_proc_prof.Size = new System.Drawing.Size(283, 20);
            this.tb_proc_prof.TabIndex = 1;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(13, 39);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(221, 39);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_exibir.TabIndex = 3;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(713, 11);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // fmr_professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_proc_prof);
            this.Controls.Add(this.dgv_professor);
            this.Name = "fmr_professores";
            this.Text = "fmr_professores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_professor;
        private System.Windows.Forms.TextBox tb_proc_prof;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Button btn_voltar;
    }
}