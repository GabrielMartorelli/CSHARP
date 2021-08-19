using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitema_PI
{
    public partial class fmr_menu_seguro : Form
    {
        public fmr_menu_seguro()
        {
            InitializeComponent();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_cadastrar_produtos fmr = new fmr_cadastrar_produtos();
            fmr.Show();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_exibir_produtos fmr = new fmr_exibir_produtos();
            fmr.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_principal fmr = new fmr_menu_principal();
            fmr.Show();
        }
    }
}
