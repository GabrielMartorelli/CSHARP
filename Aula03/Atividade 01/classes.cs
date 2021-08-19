using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_01
{
    class classes
    {
        #region "ATRIBUTOS FORNECEDOR"
        private int ID;
        private double Preço;
        private string Qualidade;
        private int Quantidade;
        private string Prazo;
        private string Nome;
        private int CodFornecedor;
        private string Endereço;
        #endregion
        #region "METODOS FORNECEDOR"
        public void M1() { MessageBox.Show("Mostrando"); }
        public void M2() { Console.WriteLine(Prazo.ToString()); }
        public void M3() { Console.WriteLine(CodFornecedor.GetType()); }
        public void M4() { Console.WriteLine(Quantidade.CompareTo(Qualidade)); }
        #endregion
        #region "ATRIBUTOS PRODUTOS"
        private int IDProd;
        private int Cod;
        private string Desc;
        private double PreçoProd;
        private int Qtde;
        private int Unidade;
        private double Peso;
        private string NomeFornecedor;

        
        #endregion
        #region "METODOS PRODUTO"
        public void M5() { MessageBox.Show("Testar"); }
        public void M6() { Console.WriteLine(PreçoProd.ToString()); }
        public void M7() { Console.WriteLine(Peso.GetType()); }
        public void M8() { Console.WriteLine(PreçoProd.CompareTo(Qtde)); }
        #endregion
        #region "GET SET FORNECEDOR"
        public int ID1 { get => ID; set => ID = value; }
        public double Preço1 { get => Preço; set => Preço = value; }
        public string Qualidade1 { get => Qualidade; set => Qualidade = value; }
        public int Quantidade1 { get => Quantidade; set => Quantidade = value; }
        public string getPrazo() { return this.Prazo; }
        public void setPrazo(string value) { this.Prazo = value; }
        public string getNome() { return this.Nome; }
        public void setNome(string value) { this.Nome = value; }
        public int getCodFornecedor() { return this.CodFornecedor; }
        public void setCodFornecedor(int value) { this.CodFornecedor = value; }
        public string getEndereço() { return this.Endereço; }
        public void setEndereço(string value) { this.Endereço = value; }
        #endregion
        #region "GET SET PRODUTO"
        public int IDProd1 { get => IDProd; set => IDProd = value; }
        public int Cod1 { get => Cod; set => Cod = value; }
        public string Desc1 { get => Desc; set => Desc = value; }
        public double PreçoProd1 { get => PreçoProd; set => PreçoProd = value; }
        public int getQtde() { return this.Qtde; }
        public void setQtde(int value) { this.Qtde = value; }
        public int getUnidade() { return this.Unidade; }
        public void setUnidade(int value) { this.Unidade = value; }
        public double getPeso() { return this.Peso; }
        public void setPeso(double value) { this.Peso = value; }
        public string getNomeFornecedor() { return this.NomeFornecedor; }
        public void setNomeFornecedor(string value) { this.NomeFornecedor = value; }
        #endregion
    }
}
