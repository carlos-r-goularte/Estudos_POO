using System;

namespace TestesMembrosEstaticos
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            /* Não há necessidade de instanciar objetos da classe, sendo que os metodos são estáticos*/
            double circunferencia = Calculadora.Circunferencia(raio);    
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2"));

            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi);
        }
    }
}