using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");

            retangulo.Altura = double.Parse(Console.ReadLine());
            retangulo.Largura = double.Parse(Console.ReadLine());


            Console.WriteLine(retangulo);
                        
        }
    }
}
