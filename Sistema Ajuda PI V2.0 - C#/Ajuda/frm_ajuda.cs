using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajuda
{
    public partial class frm_ajuda : Form
    {
        public frm_ajuda()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // frm_menu frm = new frm_menu();
            // this.Close();
        }

        private void btn_ajuda1_Click(object sender, EventArgs e)
        {
            frm_ajuda1 frm = new frm_ajuda1();
            frm.Show();
            

        }

        private void btn_ajuda2_Click(object sender, EventArgs e)
        {
            frm_ajuda2 frm = new frm_ajuda2();
            frm.Show();
            
        }

        private void btn_ajuda3_Click(object sender, EventArgs e)
        {
            frm_ajuda3 frm = new frm_ajuda3();
            frm.Show();
            
        }

        private void btn_ajuda4_Click(object sender, EventArgs e)
        {
            frm_ajuda4 frm = new frm_ajuda4();
            frm.Show();
            
        }

        private void btn_ajuda5_Click(object sender, EventArgs e)
        {
            frm_ajuda5 frm = new frm_ajuda5();
            frm.Show();
          
        }

        private void btn_ajuda6_Click(object sender, EventArgs e)
        {
            frm_ajuda6 frm = new frm_ajuda6();
            frm.Show();
        }

    }
}
