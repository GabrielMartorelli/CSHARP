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
        //Instancia de comandos
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
            this.Close();//fecha o Form atual
            fmr_menu fmr = new fmr_menu();//declara o form
            fmr.Show();//abre o form declarado
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            i = 0;//declara o i como zero
            try//tryCatch para redundancia
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                conexao.Open();//abre conexão

                strSql = "SELECT * FROM TB_LOGIN WHERE EMAIL ='" + tb_email.Text + "' AND SENHA ='" + tb_senha.Text + "'";//linha de comando pra consulta no Bd
                comando = new MySqlCommand(strSql, conexao);//guarda a linha de comando e a conexão
                comando.ExecuteNonQuery();//execulta

                DataTable dt = new DataTable();//declara do dataTable
                da = new MySqlDataAdapter(strSql, conexao);//guarda as informações da consulta com o BD
                da.Fill(dt);//preenche o DT com as informações
                i = Convert.ToInt32(dt.Rows.Count.ToString());//conta as linhas de informações

                if (i == 0)//caso não venha nenhuma linha
                {
                    MessageBox.Show("Email e/ou senha incorreto");//as informações de consuta não existe no BD
                }
                else//caso tenha
                {
                    this.Hide();//esconde o form
                    fmr_menu_logado fmr = new fmr_menu_logado();//declara o form 
                    fmr.Show();//mostra o form declarado
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
    }
}
