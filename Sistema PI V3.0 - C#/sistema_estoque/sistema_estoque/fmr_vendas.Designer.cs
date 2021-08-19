namespace sistema_estoque
{
    partial class fmr_vendas
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
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.bt_avancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vendas
            // 
            this.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendas.Location = new System.Drawing.Point(12, 12);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.Size = new System.Drawing.Size(776, 392);
            this.dgv_vendas.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(13, 410);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // bt_avancar
            // 
            this.bt_avancar.Location = new System.Drawing.Point(713, 410);
            this.bt_avancar.Name = "bt_avancar";
            this.bt_avancar.Size = new System.Drawing.Size(75, 23);
            this.bt_avancar.TabIndex = 2;
            this.bt_avancar.Text = "Avançar";
            this.bt_avancar.UseVisualStyleBackColor = true;
            this.bt_avancar.Click += new System.EventHandler(this.bt_avancar_Click);
            // 
            // fmr_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_avancar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_vendas);
            this.Name = "fmr_vendas";
            this.Text = "fmr_vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button bt_avancar;
    }
}