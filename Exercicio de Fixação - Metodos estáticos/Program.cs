using System;

namespace Exercicio_de_Fixação___Metodos_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdeDolar = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.DolarParaReal(cotacao,qtdeDolar);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2"));
        }
    }
}
