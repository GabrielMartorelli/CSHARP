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
        //instancia de comandos
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
            this.Close();//fecha o form atual
            fmr_menu_logado fmr = new fmr_menu_logado();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //irá salvar as infomrações colocadas no BD
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com Bd

                strSql = "INSERT INTO TB_PRODUTO(NOME, VALOR, CATEGORIA, PROFESSOR, PERIODO, ESTATUS) VALUES(@NOME, @VALOR, @CATEGORIA, @PROFESSOR, @PERIODO, @ESTATUS)";//linha de comando para consulta

                comando = new MySqlCommand(strSql, conexao);//guarda a linha de comando e a conexão
                comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                comando.Parameters.AddWithValue("@VALOR", tb_valor.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", tb_categoria.Text);
                comando.Parameters.AddWithValue("@PROFESSOR", tb_professor.Text);
                comando.Parameters.AddWithValue("@PERIODO", tb_periodo.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tb_estatus.Text);
                //parametros usados na linha de comando

                conexao.Open();//abre conexão
                comando.ExecuteNonQuery();//execulta tudo

            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;
                comando = null;
                //limpa a linha de conexão e comando
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //UPDATE nas informações já salvas no BD
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "UPDATE TB_PRODUTO SET NOME=@NOME, VALOR=@VALOR, CATEGORIA=@CATEGORIA, PROFESSOR=@PROFESSOR, PERIODO=@PERIODO, ESTATUS=@ESTATUS WHERE ID_PRODUTO=@ID";//linha de comando para consulta no BD

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@ID", tb_id.Text);
                comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                comando.Parameters.AddWithValue("@VALOR", tb_valor.Text);
                comando.Parameters.AddWithValue("@CATEGORIA", tb_categoria.Text);
                comando.Parameters.AddWithValue("@PROFESSOR", tb_professor.Text);
                comando.Parameters.AddWithValue("@PERIODO", tb_periodo.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tb_estatus.Text);
                //parametros usados na linha de comando

                conexao.Open();//abre conexão
                comando.ExecuteNonQuery();//executa tudo
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;
                comando = null;
                //limpa a linha de conexão e comando
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //exclui informações do BD
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "DELETE FROM TB_PRODUTO WHERE ID_PRODUTO=@ID";//linha de comando para consulta

                comando = new MySqlCommand(strSql, conexao);//guarda a linha de comando e a conexão
                comando.Parameters.AddWithValue("@ID", tb_id.Text);//parametro usado na linha de comando

                conexao.Open();//abre conexão
                comando.ExecuteNonQuery();//execulta
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;
                comando = null;
                //limpa a linha de conexão e comando
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            //pega dos as informações do BD onde for igual ao parametro
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO=@ID";//linha de comando para a consulta

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@ID", tb_id.Text);
                //parametros usados na linha de comando

                conexao.Open();//abre a conexão

                dr = comando.ExecuteReader();//executa
                while (dr.Read())
                {
                    tb_nome.Text = Convert.ToString(dr["nome"]);
                    tb_valor.Text = Convert.ToString(dr["valor"]);
                    tb_categoria.Text = Convert.ToString(dr["categoria"]);
                    tb_professor.Text = Convert.ToString(dr["professor"]);
                    tb_periodo.Text = Convert.ToString(dr["periodo"]);
                    tb_estatus.Text = Convert.ToString(dr["estatus"]);
                    //converte as informações do BD para String e coloca nas texBox
                }
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;
                comando = null;
                //limpa a linha de conexão e comando
            }
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            //pega todas as informações do BD
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_PRODUTO";//linha de comando para consulta

                da = new MySqlDataAdapter(strSql, conexao);//guarda a conexão e a linha de comando

                DataTable dt = new DataTable();//declara dataTable
                da.Fill(dt);//preenche DT com informações do BD
                dgv_produto.DataSource = dt;//Mostra as informações do BD no dataGrid
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;
                comando = null;
                //limpa a linha de conexão e comando
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
            //Limpa os textBox
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
