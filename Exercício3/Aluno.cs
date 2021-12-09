using System;

namespace Exercício3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public bool Aprovacao()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public double Restante()
        {
            return 100 - (Nota1 + Nota2 + Nota3);
        }
    }
}
