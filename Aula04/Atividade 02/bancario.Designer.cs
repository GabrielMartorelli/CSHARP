
namespace Atividade_02
{
    partial class bancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bancario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_nome = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_conta = new System.Windows.Forms.MaskedTextBox();
            this.msk_agencia = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_tipo = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_saldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade_02.Properties.Resources.cash_512_icon_icons_com_75969;
            this.pictureBox1.Location = new System.Drawing.Point(552, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dados da Conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de Agência:";
            // 
            // msk_nome
            // 
            this.msk_nome.Location = new System.Drawing.Point(100, 40);
            this.msk_nome.Name = "msk_nome";
            this.msk_nome.Size = new System.Drawing.Size(180, 20);
            this.msk_nome.TabIndex = 10;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(48, 66);
            this.msk_cpf.Mask = "000-000-000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(83, 20);
            this.msk_cpf.TabIndex = 11;
            // 
            // msk_conta
            // 
            this.msk_conta.Location = new System.Drawing.Point(113, 124);
            this.msk_conta.Mask = "000000000-0";
            this.msk_conta.Name = "msk_conta";
            this.msk_conta.Size = new System.Drawing.Size(71, 20);
            this.msk_conta.TabIndex = 12;
            // 
            // msk_agencia
            // 
            this.msk_agencia.Location = new System.Drawing.Point(113, 94);
            this.msk_agencia.Mask = "0000-0";
            this.msk_agencia.Name = "msk_agencia";
            this.msk_agencia.Size = new System.Drawing.Size(41, 20);
            this.msk_agencia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Conta:";
            // 
            // msk_tipo
            // 
            this.msk_tipo.Location = new System.Drawing.Point(92, 150);
            this.msk_tipo.Mask = "00";
            this.msk_tipo.Name = "msk_tipo";
            this.msk_tipo.Size = new System.Drawing.Size(21, 20);
            this.msk_tipo.TabIndex = 15;
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(76, 176);
            this.msk_telefone.Mask = "(999) 000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(78, 20);
            this.msk_telefone.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefone:";
            // 
            // btn_saldo
            // 
            this.btn_saldo.Location = new System.Drawing.Point(10, 216);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(270, 23);
            this.btn_saldo.TabIndex = 18;
            this.btn_saldo.Text = "Mostrar Saldo";
            this.btn_saldo.UseVisualStyleBackColor = true;
            // 
            // bancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 316);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.msk_tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_agencia);
            this.Controls.Add(this.msk_conta);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bancario";
            this.Text = "Sistema Bancário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_nome;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.MaskedTextBox msk_conta;
        private System.Windows.Forms.MaskedTextBox msk_agencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_tipo;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_saldo;
    }
}

