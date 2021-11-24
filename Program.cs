using System;

namespace Estudos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.Write("Digite seu nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome de seu companheir@: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Digite a idade de seu companheir@: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Pessoa1: " + "Nome: " + p1.Nome + "  Idade: " + p1.Idade);
            Console.WriteLine("Dados da Pessoa2: " + "Nome: " + p2.Nome + "  Idade: " + p2.Idade);

            if (p1.Idade < p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
        }
    }
}
