using System;

namespace Estudos_POO
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p3 = new Pessoas();

            Console.Write("Digite seu nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome de seu companheir@: ");
            p3.nome = Console.ReadLine();

            Console.Write("Digite a idade de seu companheir@: ");
            p3.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Pessoa1: " + "Nome: " + p1.nome + "  Idade: " + p1.idade);
            Console.WriteLine("Dados da Pessoa2: " + "Nome: " + p3.nome + "  Idade: " + p3.idade);

            p1.maiorIdade(p2.idade);
        }*/

        static void main(string[] args)
        {
            Produtos produto = new Produtos();

            Console.WriteLine("Digite o nome do produto: ");
            produto.nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            produto.preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em estoque do produto: ");
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Produto cadastrado com sucesso!");




            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - adicionar ao estoque");
            Console.WriteLine("2 - remover do estoque");
            char opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case '1':

                  
                break;

                case '2':

                break;

                default
                    
            }
        }
    }
}
