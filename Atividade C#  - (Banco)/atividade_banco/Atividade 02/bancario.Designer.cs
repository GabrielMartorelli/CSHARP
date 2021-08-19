
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.bt_dinheiro = new System.Windows.Forms.Button();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_num_ag = new System.Windows.Forms.TextBox();
            this.tb_num_cont = new System.Windows.Forms.TextBox();
            this.tb_tipo_cont = new System.Windows.Forms.TextBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade_02.Properties.Resources.cash_512_icon_icons_com_75969;
            this.pictureBox1.Location = new System.Drawing.Point(380, 236);
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
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de Agência:";
            // 
            // msk_nome
            // 
            this.msk_nome.Location = new System.Drawing.Point(119, 43);
            this.msk_nome.Name = "msk_nome";
            this.msk_nome.Size = new System.Drawing.Size(180, 20);
            this.msk_nome.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Conta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefone:";
            // 
            // btn_saldo
            // 
            this.btn_saldo.Location = new System.Drawing.Point(5, 223);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(144, 23);
            this.btn_saldo.TabIndex = 18;
            this.btn_saldo.Text = "Mostrar Saldo";
            this.btn_saldo.UseVisualStyleBackColor = true;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // bt_dinheiro
            // 
            this.bt_dinheiro.Location = new System.Drawing.Point(155, 223);
            this.bt_dinheiro.Name = "bt_dinheiro";
            this.bt_dinheiro.Size = new System.Drawing.Size(144, 23);
            this.bt_dinheiro.TabIndex = 19;
            this.bt_dinheiro.Text = "Sacar dinheiro";
            this.bt_dinheiro.UseVisualStyleBackColor = true;
            this.bt_dinheiro.Click += new System.EventHandler(this.bt_dinheiro_Click);
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(119, 69);
            this.tb_cpf.MaxLength = 11;
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(100, 20);
            this.tb_cpf.TabIndex = 20;
            // 
            // tb_num_ag
            // 
            this.tb_num_ag.Location = new System.Drawing.Point(119, 94);
            this.tb_num_ag.MaxLength = 4;
            this.tb_num_ag.Name = "tb_num_ag";
            this.tb_num_ag.Size = new System.Drawing.Size(100, 20);
            this.tb_num_ag.TabIndex = 21;
            // 
            // tb_num_cont
            // 
            this.tb_num_cont.Location = new System.Drawing.Point(119, 124);
            this.tb_num_cont.MaxLength = 8;
            this.tb_num_cont.Name = "tb_num_cont";
            this.tb_num_cont.Size = new System.Drawing.Size(100, 20);
            this.tb_num_cont.TabIndex = 22;
            // 
            // tb_tipo_cont
            // 
            this.tb_tipo_cont.Location = new System.Drawing.Point(119, 153);
            this.tb_tipo_cont.MaxLength = 1;
            this.tb_tipo_cont.Name = "tb_tipo_cont";
            this.tb_tipo_cont.Size = new System.Drawing.Size(100, 20);
            this.tb_tipo_cont.TabIndex = 23;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(119, 183);
            this.tb_telefone.MaxLength = 8;
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(100, 20);
            this.tb_telefone.TabIndex = 24;
            // 
            // bancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 319);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_tipo_cont);
            this.Controls.Add(this.tb_num_cont);
            this.Controls.Add(this.tb_num_ag);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.bt_dinheiro);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.Button bt_dinheiro;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_num_ag;
        private System.Windows.Forms.TextBox tb_num_cont;
        private System.Windows.Forms.TextBox tb_tipo_cont;
        private System.Windows.Forms.TextBox tb_telefone;
    }
}

