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
    public partial class frm_ajuda6 : Form
    {
        public frm_ajuda6()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ajuda frm = new frm_ajuda();
            this.Close();
        }
    }
}
