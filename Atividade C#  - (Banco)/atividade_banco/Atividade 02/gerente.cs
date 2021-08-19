using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_02
{
    class gerente
    {
        #region ATRIBUTOS
        private double credito;
        private double saque;
        #endregion

        #region METODOS
        public gerente() { }

        public gerente(double credito, double saque)
        {
            this.credito = credito;
            this.saque = saque;
        }
        #endregion

        #region GET SET
        public double getcredito() { return this.credito; }
        public void setcredito(double value) { this.credito = value; }

        public double getsaque() { return this.saque; }
        public void setsaque(double value){ this.saque = value; }
        #endregion
    }
}
