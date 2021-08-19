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
    public partial class fmr_cadastro_aluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;

        public fmr_cadastro_aluno(int id)
        {
            InitializeComponent();

            try
            {
                conexao = new MySqlConnection("Server=localhost;user id=root;password=;database=sistemapidb");
                strSql = "SELECT nome, valor, periodo, ativo FROM produto WHERE idProdutos= '" + id + "'";

                comando = new MySqlCommand(strSql, conexao);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tbx_nome_prod.Text = Convert.ToString(dr["nome"]);
                    tbx_valor_prod.Text = Convert.ToString(dr["valor"]);
                    tbx_periodo_prod.Text = Convert.ToString(dr["periodo"]);
                    tbx_status_prod.Text = Convert.ToString(dr["ativo"]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            conexao bd = new conexao();
            try
            {
                bd.conectar();

                bd.ExecutarComando("INSERT INTO aluno(NOME, EMAIL, CPF, MATRICULA, CURSO, FORMAPAGAMENTO) VALUES('" + tbx_nome_aluno.Text + "','" + tbx_email_aluno.Text + "','" + tbx_cpf_aluno.Text + "','" + tbx_matricula_aluno.Text + "','" + tbx_nome_prod.Text + "','" + tbx_forma_aluno.Text + "')");
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
