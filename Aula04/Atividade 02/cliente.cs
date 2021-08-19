using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    class cliente
    {
        #region ATRIBUTOS
        private string nome;
        private int cpf;
        private int numag;
        private int numcont;
        private int tipoconta;
        private int telefone;
        #endregion
        #region METODOS
        string[] cli = new string[6] { "nome", "cpf", "numag","numcont", "tipoconta", "telefone" };
        #endregion
        #region GET SET
        public string getnome() { return this.nome; }
        public void setnome(string value) { this.nome = value; }
        public int getcpf() { return this.cpf; }
        public void setcpf(int value) { this.cpf = value; }
        public int getnumag() { return this.numag; }
        public void setnumag(int value) { this.numag = value; }
        public int Numcont { get => numcont; set => numcont = value; }
        public int Tipoconta { get => tipoconta; set => tipoconta = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        #endregion
    }
}
