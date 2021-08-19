using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm= new frm_produtos();
            frm.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void btn_criar_venda_Click(object sender, EventArgs e)
        {
            frm_criar_vendas frm = new frm_criar_vendas();
            frm.Show();
        }

        private void btn_con_vendas_Click(object sender, EventArgs e)
        {
            frm_con_vendas frm = new frm_con_vendas();
            frm.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cursos frm = new frm_cursos();
            frm.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ajudaprinc frm = new frm_ajudaprinc();
            frm.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_professores frm = new frm_professores();
            frm.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_grupo frm = new frm_grupo();
            frm.Show();
        }
    }
}
