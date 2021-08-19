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
        //instancia de comandos
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSql;

        public fmr_vendas()
        {
            InitializeComponent();

            //pega todas as informações onde for igual ao parametro
            try//tryCatch redundancia para erro
            {
                conexao = new MySqlConnection("Server=localhost;Database=bdsistema;Uid=root;Pwd=");//conexão com o BD
                strSql = "SELECT * FROM TB_PRODUTO WHERE ESTATUS ='" + 0 + "'";//linha de comando para consulta

                da = new MySqlDataAdapter(strSql, conexao);//guarda a conexão e a linha de comando

                DataTable dt = new DataTable();//declara dataTable
                da.Fill(dt);//preenche DT com informações do BD
                dgv_vendas.DataSource = dt;//Mostra as informações do BD no dataGrid
            }
            catch (Exception ex)//caso o try não seja executado o catch será
            {
                MessageBox.Show(ex.Message);//mostra o erro do porque o try não foi executado
            }
            finally//cado o try seja executado normalmente o finally será também
            {
                conexao.Close();//fecha conexão
                conexao = null;//limpa a linha de conexão e comando
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form atual
            fmr_menu fmr = new fmr_menu();//declara o form
            fmr.Show();//exibe o form declarado
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o form atual
            fmr_vend_curso fmr = new fmr_vend_curso();//declara o form
            fmr.Show();//exibe o form declarado
        }
    }
}
