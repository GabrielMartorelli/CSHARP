using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_estoque
{
    public partial class fmr_menu_logado : Form
    {
        public fmr_menu_logado()
        {
            InitializeComponent();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu fmr = new fmr_menu();
            fmr.Show();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_produto fmr = new fmr_produto();
            fmr.Show();
        }
    }
}
