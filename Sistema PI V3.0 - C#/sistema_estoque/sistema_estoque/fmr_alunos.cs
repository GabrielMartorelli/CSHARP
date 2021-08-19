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
    public partial class fmr_alunos : Form
    {
        //intacia de comandos
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        string id_aluno;

        public fmr_alunos()
        {
            InitializeComponent();

            //No momento que abrir o form o sistema irá fazer uma consulta no form que exibirá tudo o que tem na tabela alunos
            try//tryCatch para redundancia 
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//faz a conexão com o BD
                strSql = "SELECT * FROM TB_ALUNOS";//linha de comando para fazer a consulta no BD

                da = new MySqlDataAdapter(strSql, conexao);//Executa a linha de comando e guarda as informação

                DataTable dt = new DataTable();//declara o dataTable
                da.Fill(dt);//coloca as informações no dataTable
                dgv_alunos.DataSource = dt;//coloca as informações do DT no DataGrid
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//e mostrará o erro que fez o try não ser execultado
            }
            finally//se o try for executado normalmente o finally 
            {
                conexao.Close();//fechara a conexão com o BD
                conexao = null;
                comando = null;
                //e limpará os comando
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form
            fmr_menu fmr = new fmr_menu();//declara o form
            fmr.Show();//abre o form declarado
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            //faz consulta na tabela alunos onde o CPF for igual ao colocado
            try//tryCatch para redundancia 
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o banco de dados
                strSql = "SELECT * FROM TB_ALUNOS WHERE CPF=@CPF";//linha de comando para consulta no BD

                comando = new MySqlCommand(strSql, conexao);//guarda a conxão e linha de comando
                comando.Parameters.AddWithValue("@CPF", tb_cpf_aluno.Text);//parametro para a linha de comando execultar

                conexao.Open();//abre a conexão com o BD

                dr = comando.ExecuteReader();//execulta
                while (dr.Read())//preenche os textBox com informações do BD
                {
                    id_aluno = Convert.ToString(dr["id_alunos"]);//guarda o id dos alunos pesquisados para usar depois
                    tb_nome_aluno.Text = Convert.ToString(dr["nome"]);
                    tb_email_aluno.Text = Convert.ToString(dr["email"]);
                    tb_matri_aluno.Text = Convert.ToString(dr["ra"]);
                    tb_curso_aluno.Text = Convert.ToString(dr["curso"]);
                    tb_stats_aluno.Text = Convert.ToString(dr["estatus"]);
                    //converte as informações do BD para String e coloca nas texBox
                }
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//e mostrará o erro que fez o try não ser execultado
            }
            finally//se o try for executado normalmente o finally 
            {
                conexao.Close();//fechara a conexão com o BD
                conexao = null;
                comando = null;
                //e limpará os comando
            }
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            //consulta no form que exibirá tudo o que tem na tabela alunos
            try//tryCatch para redundancia 
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_ALUNOS";//Linha de comando para consulta no BD

                da = new MySqlDataAdapter(strSql, conexao);//Execulta a linha de comando

                DataTable dt = new DataTable();//declara do dataTable
                da.Fill(dt);//guarda as informações no DT 
                dgv_alunos.DataSource = dt;//preenche o dataGrid com informações do BD
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//e mostrará o erro que fez o try não ser execultado
            }
            finally//se o try for executado normalmente o finally 
            {
                conexao.Close();//fechara a conexão com o BD
                conexao = null;
                comando = null;
                //e limpará os comando
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //fara UPDATE nas infomações já salvas no BD
            try//tryCatch para redundancia 
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "UPDATE TB_ALUNOS SET NOME=@NOME, EMAIL=@EMAIL, RA=@RA, CURSO=@CURSO, ESTATUS=@ESTATUS WHERE ID_ALUNOS='"+id_aluno+"'";//linha de comando

                comando = new MySqlCommand(strSql, conexao);//guarda a conexão e a linha de comando
                comando.Parameters.AddWithValue("@CPF", tb_cpf_aluno.Text);
                comando.Parameters.AddWithValue("@NOME", tb_nome_aluno.Text);
                comando.Parameters.AddWithValue("@EMAIL", tb_email_aluno.Text);
                comando.Parameters.AddWithValue("@RA", tb_matri_aluno.Text);
                comando.Parameters.AddWithValue("@CURSO", tb_curso_aluno.Text);
                comando.Parameters.AddWithValue("@ESTATUS", tb_stats_aluno.Text);//parametros que seram usados na linha de comando

                conexao.Open();//abre conexão
                comando.ExecuteNonQuery();//execulta tudo
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//e mostrará o erro que fez o try não ser execultado
            }
            finally//se o try for executado normalmente o finally
            {
                conexao.Close();//fechara a conexão com o BD
                conexao = null;
                comando = null;
                //e limpará os comando
            }
        }
    }
}
