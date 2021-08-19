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
    public partial class fmr_menu : Form
    {
        public fmr_menu()
        {
            InitializeComponent();
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_vendas fmr = new fmr_vendas();
            fmr.Show();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_cursos fmr = new fmr_cursos();
            fmr.Show();
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_alunos fmr = new fmr_alunos();
            fmr.Show();
        }

        private void btn_professores_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_professores fmr = new fmr_professores();
            fmr.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_logar fmr = new fmr_logar();
            fmr.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_ajuda fmr = new fmr_ajuda();
            fmr.Show();
        }
    }
}
