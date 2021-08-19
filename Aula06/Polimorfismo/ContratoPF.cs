using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ContratoPF : Contrato
    {
        #region Atributos
        public int Idade_Contratante;
        public int CPF;
        public float Valor_Reajustado;
        #endregion
        #region Metodos
        public void CalcularPrestacao()
        {
          if (Idade_Contratante <= 30) { Valor_Reajustado = Valor + 1; }
           if (Idade_Contratante <= 40) { Valor_Reajustado = Valor + 2; }
             if (Idade_Contratante <= 50) { Valor_Reajustado = Valor + 3; }
                if (Idade_Contratante > 50) { Valor_Reajustado = Valor + 4; }
        }
        #endregion
    }
}
