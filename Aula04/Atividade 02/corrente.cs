using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    class corrente
    {
        #region ATRIBUTOS
        private double saldo;
        private int ncont;
        private int tipo;
        #endregion
        #region METODOS
        // if (Tipoconta == 1 && setcpf == "") {}
        string[] poup = new string[3] { "saldo", "ncont", "tipo" };
        #endregion
        #region GET SET
        public double getsaldo() { return this.saldo; }
        public void setsaldo(double value) { this.saldo = value; }
        public int getncont() { return this.ncont; }
        public void setncont(int value) { this.ncont = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        #endregion
    }
}
