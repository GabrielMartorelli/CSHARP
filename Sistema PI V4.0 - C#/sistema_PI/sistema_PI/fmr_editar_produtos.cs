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
    public partial class fmr_editar_produtos : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;

        public fmr_editar_produtos(int id)
        {
            InitializeComponent();
            try
            {
                conexao = new MySqlConnection("Server=localhost;user id=root;password=;database=sistemapidb");
                strSql = "SELECT * FROM produto WHERE idProdutos= '" + id +"'";

                comando = new MySqlCommand(strSql, conexao);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tbx_nome_prod.Text = Convert.ToString(dr["nome"]);
                    tbx_valor_prod.Text = Convert.ToString(dr["valor"]);
                    tbx_categoria_prod.Text = Convert.ToString(dr["categoria"]);
                    tbx_periodo_prod.Text = Convert.ToString(dr["periodo"]);
                    tbx_status_prod.Text = Convert.ToString(dr["ativo"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cadastrar_prod_Click(object sender, EventArgs e)
        {
            conexao bd = new conexao();
            try
            {
                
                bd.conectar();

                bd.ExecutarComando("UPDATE produto SET nome ='" + tbx_nome_prod.Text + "', valor ='" + tbx_valor_prod.Text + "', categoria ='" + tbx_categoria_prod.Text + "', periodo ='" + tbx_periodo_prod.Text + "', ativo ='" + tbx_status_prod.Text + "'");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Abort;
            }
            finally
            {
                bd = null;
            }
        }
    }
}
