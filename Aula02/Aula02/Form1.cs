using Aula02.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Produto p = new Produto();
            //p.ID = 1;
           //p.CodigoProduto = txtCodigoProduto.Text;
            //p.Descricao = txtDescricao.Text;
            //p.Preco = double.Parse(txtpreco.Text);
            //p.Quantidade = double.Parse(txtQuantidade.Text);
            //p.Unidade = txtUnidade.Text;

            p.Mostrar();

            Produto p = new Produto(2, txtCodigoProduto.Text,txtDescricao.Text, double.Parse(txtpreco.Text), 
            double.Parse(txtQuantidade.Text), txtUnidade.Text);

        }
    }
}
