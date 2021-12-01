using System;

namespace Estudos_POO
{
    class Pessoas
    {

        public string nome;
        public int idade;


        public void maiorIdade(int idade2, string nome2)
        {
                        
            if (idade > idade2)
            {
                Console.WriteLine(nome + " é mais velho que " + nome2);
            }
            else
            {
                Console.WriteLine(nome + " é mais nova " + nome2);
            }
        }

    }
}
