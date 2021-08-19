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
    public partial class fmr_vendas : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSql;

        public fmr_vendas()
        {
            InitializeComponent();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                strSql = "SELECT * FROM TB_PRODUTO WHERE ESTATUS ='" + 0 + "'";

                da = new MySqlDataAdapter(strSql, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_vendas.DataSource = dt;
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu fmr = new fmr_menu();
            fmr.Show();
        }
    }
}
