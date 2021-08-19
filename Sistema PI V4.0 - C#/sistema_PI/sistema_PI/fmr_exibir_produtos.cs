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
    public partial class fmr_exibir_produtos : Form
    {
        public fmr_exibir_produtos()
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
                dgv_produtos.DataSource = bd.RetDataTable("SELECT * FROM produto");
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

        private void btn_excluir_prod_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja remover o produto selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgv_produtos.SelectedRows.Count; i++)
                    {
                        int id = int.Parse(dgv_produtos.SelectedRows[i].Cells["idProdutos"].Value.ToString());
                        if (deletarProduto(id))
                        {
                            carregarGrid();
                        }
                    }
                    MessageBox.Show("Produto Deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool deletarProduto(int id)
        {
            conexao bd = new conexao();
            bd.conectar();
            bd.ExecutarComando("DELETE FROM produto WHERE idProdutos = '" + id + "'");
            return true;
        }

        private void btn_editar_prod_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgv_produtos.SelectedRows[0].Cells["idProdutos"].Value.ToString());
                fmr_editar_produtos edita = new fmr_editar_produtos(id);
                if (edita.ShowDialog() == DialogResult.OK)
                {
                    carregarGrid();
                    MessageBox.Show("Produto alterado com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Selecione apenas um produto");
                }
            }
        }

        private void tb_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            fmr_menu_seguro fmr = new fmr_menu_seguro();
            fmr.Show();
        }
    }
}
