using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitema_PI
{
    public partial class fmr_cursos_disponiveis : Form
    {
        public fmr_cursos_disponiveis()
        {
            InitializeComponent();

            carregarGrid();
        }

        private void carregarGrid()
        {
            conexao bd = new conexao();

            try
            {
                bd.conectar();
                dgv_vendas.DataSource = bd.RetDataTable("SELECT * FROM produto");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produtos - Erro: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        private void btn_cadastrar_aluno_Click(object sender, EventArgs e)
        {
            if (dgv_vendas.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgv_vendas.SelectedRows[0].Cells["idProdutos"].Value.ToString());
                fmr_cadastro_aluno cadastro = new fmr_cadastro_aluno(id);
                if (cadastro.ShowDialog() == DialogResult.OK)
                {
                    carregarGrid();
                    MessageBox.Show("Aluno cadastrado com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Selecione apenas um produto");
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_principal fmr = new fmr_menu_principal();
            fmr.Show();
        }
    }
}
