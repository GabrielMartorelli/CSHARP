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

namespace sistema_estoque
{
    public partial class fmr_logar : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        string strSql;
        int i;

        public fmr_logar()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu fmr = new fmr_menu();
            fmr.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            i = 0;
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                conexao.Open();

                strSql = "SELECT * FROM TB_LOGIN WHERE EMAIL ='" + tb_email.Text + "' AND SENHA ='" + tb_senha.Text + "'";
                comando = new MySqlCommand(strSql, conexao);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da = new MySqlDataAdapter(strSql, conexao);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Email e/ou senha incorreto");
                }
                else
                {
                    this.Hide();
                    fmr_menu_logado fmr = new fmr_menu_logado();
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
                comando = null;
            }
        }
    }
}
