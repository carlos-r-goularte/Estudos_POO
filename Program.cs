using System;

namespace Estudos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto = new Produtos();

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque do produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.WriteLine();

            string opcao = Menu();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Dados do produto: " + produto);
                        Console.WriteLine();
                        break;

                    case "2":
                        break;

                    default:

                        break;
                }

                opcao = Menu();
            }

            Console.WriteLine("Até mais!");
        }

        private static string Menu()
        {

            Console.WriteLine("==================");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("==================");

            Console.WriteLine("1 - adicionar ao estoque");
            Console.WriteLine("2 - remover do estoque");

            string opcao = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return opcao;
        }
    }
}
