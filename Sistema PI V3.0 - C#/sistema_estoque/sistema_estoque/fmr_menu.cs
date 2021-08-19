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
            this.Hide();//esconde o form atual
            fmr_vendas fmr = new fmr_vendas();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            this.Hide();//esconde o form atual
            fmr_alunos fmr = new fmr_alunos();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();//esconde o form atual
            fmr_logar fmr = new fmr_logar();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();//esconde o form atual
            fmr_ajuda fmr = new fmr_ajuda();//declara o form
            fmr.Show();//exibe o form declarado
        }
    }
}
