using System;
using System.Globalization;

namespace Exercicio_Fixacao_Membros_Estaticos
{
    class ConversorDeMoedas
    {
        public double IOF = 6.0;
        public double Cotacao;
        public double Dollars;

        public double Conversor()
        {
            return Dollars * Cotacao;
        }

        public double AjusteIOF()
        {
            return Conversor() * 0.06;
        }

        public double ValorFinal()
        {
            return Conversor() + AjusteIOF();
        }

    }
}
