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
    public partial class fmr_menu_principal : Form
    {
        public fmr_menu_principal()
        {
            InitializeComponent();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_cursos_disponiveis fmr = new fmr_cursos_disponiveis();
            fmr.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmr_menu_logar fmr = new fmr_menu_logar();
            fmr.Show();
        }
    }
}
