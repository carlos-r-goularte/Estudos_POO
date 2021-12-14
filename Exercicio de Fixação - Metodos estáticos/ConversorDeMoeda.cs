using System;


namespace Exercicio_de_Fixação___Metodos_estáticos
{
    class ConversorDeMoeda
    {
        public static double DolarParaReal(double cotacao, double qtdeDolar)
        {
            double total = cotacao * qtdeDolar;
            return total + (total * 0.06);
        }
    }
}
