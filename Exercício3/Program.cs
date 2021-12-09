using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL: "+ aluno.NotaFinal().ToString("F2"));

            if (aluno.Aprovacao())
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Faltaram: "+ aluno.Restante().ToString("F2") + " pontos!" );
            }
        }
    }
}
