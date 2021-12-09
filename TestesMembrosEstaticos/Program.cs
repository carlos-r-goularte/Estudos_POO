using System;

namespace TestesMembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2"));

            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
