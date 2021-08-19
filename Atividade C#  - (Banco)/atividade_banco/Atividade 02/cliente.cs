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
        public cliente(string nome, int cpf, int numag, int numcont, int tipoconta, int telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.numag = numag;
            this.numcont = numcont;
            this.tipoconta = tipoconta;
            this.telefone = telefone;
        }

        public cliente(){ }
        #endregion

        #region GET SET
        public string getnome() { return this.nome; }
        public void setnome(string value) { this.nome = value; }

        public int getcpf() { return this.cpf; }
        public void setcpf(int value) { this.cpf = value; }

        public int getnumag() { return this.numag; }
        public void setnumag(int value) { this.numag = value; }
        
        public int getnumcont() { return this.numcont; }
        public void setnumcont(int value) { this.numcont = value; }

        public int gettipoconta() { return this.tipoconta; }
        public void settipoconta(int value) { this.tipoconta = value; }

        public int gettelefone() { return this.telefone; }
        public void settelefone(int value) { this.telefone = value; }
        #endregion
    }
}
