
namespace Atividade_02
{
    partial class saldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saldo));
            this.msk_saldo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_saldo
            // 
            this.msk_saldo.Location = new System.Drawing.Point(88, 39);
            this.msk_saldo.Name = "msk_saldo";
            this.msk_saldo.Size = new System.Drawing.Size(180, 20);
            this.msk_saldo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite o valor para ser sacado";
            // 
            // bt_sacar
            // 
            this.bt_sacar.Location = new System.Drawing.Point(137, 65);
            this.bt_sacar.Name = "bt_sacar";
            this.bt_sacar.Size = new System.Drawing.Size(75, 23);
            this.bt_sacar.TabIndex = 13;
            this.bt_sacar.Text = "Sacar";
            this.bt_sacar.UseVisualStyleBackColor = true;
            this.bt_sacar.Click += new System.EventHandler(this.bt_sacar_Click);
            // 
            // saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 107);
            this.Controls.Add(this.bt_sacar);
            this.Controls.Add(this.msk_saldo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "saldo";
            this.Text = "Saque";
            this.Load += new System.EventHandler(this.saldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sacar;
    }
}