namespace sistema_estoque
{
    partial class fmr_alunos
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
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.tb_cpf_aluno = new System.Windows.Forms.TextBox();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_matri_aluno = new System.Windows.Forms.TextBox();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.tb_stats_aluno = new System.Windows.Forms.TextBox();
            this.tb_email_aluno = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.tb_curso_aluno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 217);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.Size = new System.Drawing.Size(776, 221);
            this.dgv_alunos.TabIndex = 0;
            // 
            // tb_cpf_aluno
            // 
            this.tb_cpf_aluno.Location = new System.Drawing.Point(66, 15);
            this.tb_cpf_aluno.Name = "tb_cpf_aluno";
            this.tb_cpf_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_cpf_aluno.TabIndex = 1;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(713, 188);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 2;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(632, 188);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_exibir.TabIndex = 3;
            this.btn_exibir.Text = "Atualizar";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(713, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // tb_matri_aluno
            // 
            this.tb_matri_aluno.Location = new System.Drawing.Point(66, 106);
            this.tb_matri_aluno.Name = "tb_matri_aluno";
            this.tb_matri_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_matri_aluno.TabIndex = 11;
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Location = new System.Drawing.Point(66, 42);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_nome_aluno.TabIndex = 12;
            // 
            // tb_stats_aluno
            // 
            this.tb_stats_aluno.Location = new System.Drawing.Point(66, 170);
            this.tb_stats_aluno.Name = "tb_stats_aluno";
            this.tb_stats_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_stats_aluno.TabIndex = 13;
            // 
            // tb_email_aluno
            // 
            this.tb_email_aluno.Location = new System.Drawing.Point(66, 75);
            this.tb_email_aluno.Name = "tb_email_aluno";
            this.tb_email_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_email_aluno.TabIndex = 14;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(551, 188);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 16;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // tb_curso_aluno
            // 
            this.tb_curso_aluno.Location = new System.Drawing.Point(66, 138);
            this.tb_curso_aluno.Name = "tb_curso_aluno";
            this.tb_curso_aluno.Size = new System.Drawing.Size(211, 20);
            this.tb_curso_aluno.TabIndex = 15;
            // 
            // fmr_alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.tb_curso_aluno);
            this.Controls.Add(this.tb_email_aluno);
            this.Controls.Add(this.tb_stats_aluno);
            this.Controls.Add(this.tb_nome_aluno);
            this.Controls.Add(this.tb_matri_aluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.tb_cpf_aluno);
            this.Controls.Add(this.dgv_alunos);
            this.Name = "fmr_alunos";
            this.Text = "fmr_alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.TextBox tb_cpf_aluno;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_matri_aluno;
        private System.Windows.Forms.TextBox tb_nome_aluno;
        private System.Windows.Forms.TextBox tb_stats_aluno;
        private System.Windows.Forms.TextBox tb_email_aluno;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox tb_curso_aluno;
    }
}