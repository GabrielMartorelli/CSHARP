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
    public partial class fmr_ajuda : Form
    {
        public fmr_ajuda()
        {
            InitializeComponent();
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            fmr_ajuda_alunos fmr = new fmr_ajuda_alunos();
            fmr.Show();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            fmr_ajuda_vendas fmr = new fmr_ajuda_vendas();
            fmr.Show();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            fmr_ajuda_cursos fmr = new fmr_ajuda_cursos();
            fmr.Show();
        }

        private void btn_login_menu_Click(object sender, EventArgs e)
        {
            fmr_ajuda_menu_login fmr = new fmr_ajuda_menu_login();
            fmr.Show();
        }

        private void btn_prod_prof_Click(object sender, EventArgs e)
        {
            fmr_ajuda_prod_prof fmr = new fmr_ajuda_prod_prof();
            fmr.Show();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu fmr = new fmr_menu();
            fmr.Show();
        }
    }
}
