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

                        break;

                    case "2":

                        break;

                    case "3":
                        Console.WriteLine("Dados do produto: " + produto.Nome + ", R$ " + produto.Preco + ", Quantidade: " + produto.Quantidade);
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

            Console.WriteLine("1 - Adicionar Produtos ao Estoque");
            Console.WriteLine("2 - Remover Produtos do Estoque");
            Console.WriteLine("3 - Visualizar Estoque");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return opcao;

        }



    }
}
