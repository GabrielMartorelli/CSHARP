using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sitema_PI
{
    public partial class fmr_menu_logar : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        string strSql;
        int i;

        public fmr_menu_logar()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            i = 0;
            try
            {
                conexao = new MySqlConnection("Server=localhost;user id=root;password=;database=sistemapidb");
                conexao.Open();

                strSql = "SELECT * FROM logar WHERE email ='" + tbx_email.Text + "' AND senha ='" + tbx_senha.Text + "'";
                comando = new MySqlCommand(strSql, conexao);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da = new MySqlDataAdapter(strSql, conexao);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Email/senha incorreto");
                }
                else
                {
                    this.Close();
                    fmr_menu_seguro fmr = new fmr_menu_seguro();
                    fmr.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_principal fmr = new fmr_menu_principal();
            fmr.Show();
        }
    }
}
