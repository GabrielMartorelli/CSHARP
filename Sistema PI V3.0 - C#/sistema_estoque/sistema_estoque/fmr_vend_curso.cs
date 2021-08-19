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
    public partial class fmr_vend_curso : Form
    {
        //instancia de comandos
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSql;

        public fmr_vend_curso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pega todas as infomações do BD onde for igual ao parametro
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO=@ID";//linha de comando para consulta no BD

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@ID", tbx_id_curso.Text);
                //parametros usados na linha de comando

                conexao.Open();//abre conexão

                dr = comando.ExecuteReader();//executa tudo
                while (dr.Read())
                {
                    tbx_nome_curso.Text = Convert.ToString(dr["nome"]);
                    tbx_valor_curso.Text = Convert.ToString(dr["valor"]);
                    tbx_cat_curso.Text = Convert.ToString(dr["categoria"]);
                    tbx_prof_curso.Text = Convert.ToString(dr["professor"]);
                    tbx_periodo_curso.Text = Convert.ToString(dr["periodo"]);
                    tbx_ests_curso.Text = Convert.ToString(dr["estatus"]);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //salva as informações dos parametros no banco de dados
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "INSERT INTO TB_ALUNOS(NOME, EMAIL, CPF, RA, CURSO, ESTATUS) VALUES(@NOME, @EMAIL, @CPF, @RA, @CURSO, @ESTATUS)";//linha de comando para consulta no BD

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@NOME", tbx_nome_aluno.Text);
                comando.Parameters.AddWithValue("@EMAIL", tbx_email_aluno.Text);
                comando.Parameters.AddWithValue("@CPF", tbx_cpf_aluno.Text);
                comando.Parameters.AddWithValue("@RA", tbx_matri_aluno.Text);
                comando.Parameters.AddWithValue("@CURSO", tbx_nome_curso.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tbx_stats_aluno.Text);
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
                MessageBox.Show("Aluno cadastrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //gera um numero aleatório
            Random random = new Random();
            int numMatricula = random.Next(1000, 100000000);

            tbx_matri_aluno.Text = numMatricula.ToString();
        }

        private void bt_retornar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form atual
            fmr_vendas fmr_Vendas = new fmr_vendas();//declara o form
            fmr_Vendas.Show();//exibe o form declarado
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form atual
            fmr_menu fmr = new fmr_menu();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void btn_alunos_cad_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form atual
            fmr_alunos fmr = new fmr_alunos();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void btn_pesquisa_aluno_Click(object sender, EventArgs e)
        {
            //pega as informações do Bd onde for igual ao parametro
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_ALUNOS WHERE CPF=@CPF";//linha de comando para consulta no BD

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@CPF", tbx_cpf_aluno.Text);
                //parametros usados na linha de comando

                conexao.Open();//abre conexão

                dr = comando.ExecuteReader();//executa tudo
                while (dr.Read())
                {
                    tbx_nome_aluno.Text = Convert.ToString(dr["nome"]);
                    tbx_email_aluno.Text = Convert.ToString(dr["email"]);
                    tbx_matri_aluno.Text = Convert.ToString(dr["ra"]);
                    tbx_nome_curso.Text = Convert.ToString(dr["curso"]);
                    tbx_stats_aluno.Text = Convert.ToString(dr["estatus"]);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
