using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    class poupança
    {
        #region ATRIBUTOS
        private double saldo;
        private int ncont;
        private int tipo;
        #endregion

        #region METODOS
        public poupança(double saldo, int ncont, int tipo)
        {
            this.saldo = saldo;
            this.ncont = ncont;
            this.tipo = tipo;
        }

        public poupança() { }
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
