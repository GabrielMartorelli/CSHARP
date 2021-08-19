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
    public partial class fmr_cadastrar_produtos : Form
    {
        string strSql;

        public fmr_cadastrar_produtos()
        {
            InitializeComponent();
        }

        private void btn_exibir_prod_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_exibir_produtos fmr = new fmr_exibir_produtos();
            fmr.Show();
        }

        private void btn_cadastrar_prod_Click(object sender, EventArgs e)
        {
            conexao bd = new conexao();
            try
            {
                bd.conectar();

                strSql = "INSERT INTO produto(NOME, VALOR, CATEGORIA, PERIODO, ATIVO) VALUES(" + "'" + tbx_nome_prod.Text + "','" + tbx_valor_prod.Text + "','" + tbx_categoria_prod.Text + "','" + tbx_periodo_prod.Text + "','" + tbx_status_prod.Text + "')";

                bd.ExecutarComando(strSql);
                MessageBox.Show("Produto cadastrado!!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar - Erro: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_seguro fmr = new fmr_menu_seguro();
            fmr.Show();
        }
    }
}
