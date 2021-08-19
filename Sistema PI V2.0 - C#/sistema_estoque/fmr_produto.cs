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
    public partial class fmr_produto : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;

        public fmr_produto()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_logado fmr = new fmr_menu_logado();
            fmr.Show();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");

                strSql = "INSERT INTO TB_PRODUTO(NOME, VALOR, CATEGORIA, PROFESSOR, PERIODO, ESTATUS) VALUES(@NOME, @VALOR, @CATEGORIA, @PROFESSOR, @PERIODO, @ESTATUS)";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                comando.Parameters.AddWithValue("@VALOR", tb_valor.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", tb_categoria.Text);
                comando.Parameters.AddWithValue("@PROFESSOR", tb_professor.Text);
                comando.Parameters.AddWithValue("@PERIODO", tb_periodo.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tb_estatus.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                strSql = "UPDATE TB_PRODUTO SET NOME=@NOME, VALOR=@VALOR, CATEGORIA=@CATEGORIA, PROFESSOR=@PROFESSOR, PERIODO=@PERIODO, ESTATUS=@ESTATUS WHERE ID_PRODUTO=@ID";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@ID", tb_id.Text);
                comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                comando.Parameters.AddWithValue("@VALOR", tb_valor.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", tb_categoria.Text);
                comando.Parameters.AddWithValue("@PROFESSOR", tb_professor.Text);
                comando.Parameters.AddWithValue("@PERIODO", tb_periodo.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tb_estatus.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                strSql = "DELETE FROM TB_PRODUTO WHERE ID_PRODUTO=@ID";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@ID", tb_id.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                strSql = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO=@ID";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@ID", tb_id.Text);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tb_nome.Text = Convert.ToString(dr["nome"]);
                    tb_valor.Text = Convert.ToString(dr["valor"]);
                    tb_categoria.Text = Convert.ToString(dr["categoria"]);
                    tb_professor.Text = Convert.ToString(dr["professor"]);
                    tb_periodo.Text = Convert.ToString(dr["periodo"]);
                    tb_estatus.Text = Convert.ToString(dr["estatus"]);
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

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");
                strSql = "SELECT * FROM TB_PRODUTO";

                da = new MySqlDataAdapter(strSql, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_produto.DataSource = dt;
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

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            tb_categoria.Text = null;
            tb_nome.Text = null;
            tb_id.Text = null;
            tb_valor.Text = null;
            tb_professor.Text = null;
            tb_periodo.Text = null;
            tb_estatus.Text = null;
        }
    }
}
