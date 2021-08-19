using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_02
{
    public partial class bancario : Form
    {
        cliente c;
        public int tipo;

        public bancario()
        {
            InitializeComponent();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            c = new cliente(msk_nome.Text, Int32.Parse(tb_cpf.Text), Int32.Parse(tb_num_ag.Text), Int32.Parse(tb_num_cont.Text), Int32.Parse(tb_tipo_cont.Text), Int32.Parse(tb_telefone.Text));

            if (c.gettipoconta() == 1 && c.getcpf() == 123)
            {
                poupança p = new poupança(1.233, Int32.Parse(tb_num_cont.Text), Int32.Parse(tb_tipo_cont.Text));
                MessageBox.Show("O saldo é: R$" + p.getsaldo().ToString(), "Conta Poupança");
            }
            else
            {
                corrente co = new corrente(23.412, Int32.Parse(tb_num_cont.Text), Int32.Parse(tb_tipo_cont.Text));
                MessageBox.Show("O Saldo é: R$" + co.getsaldo().ToString(), "Conta Corrente");
            }     
        }

        private void bt_dinheiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            saldo s = new saldo();
            s.Show();
        }
    }
}
