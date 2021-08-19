using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ContratoPJ : Contrato
    {
        #region Atributos
        public int CPNJ;
        public int Inscricao_Estadual;
        public float Valor_Reajustado;
        #endregion

        #region Metodos
        public void CalcularPrestacao()
        {
            Valor_Reajustado = Valor + 3;
        }
        #endregion
    }
}
