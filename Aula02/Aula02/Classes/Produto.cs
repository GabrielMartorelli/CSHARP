using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02.Classes
{
    public class Produto
    {
        #region "METODO CONSTRUTOR"
        public Produto();
        
        #endregion
        #region "ATRIBUTOS"
        public int ID;
        public string CodigoProduto;
        public string Descricao;
        public double Preco;
        public double Quantidade;
        public string Unidade;
        #endregion
        #region "METODOS"
        public void Mostrar()
        {
            MessageBox.Show("Código" + this.CodigoProduto + 
                "Descrição:" + this.Descricao);
        }

        #endregion
    }
}
