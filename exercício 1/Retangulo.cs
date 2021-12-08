using System;

namespace Exercício_1
{
    class Retangulo
    {

        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {

            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        public override string ToString()
        {
            return "ÁREA: "
                + Area().ToString("F2")
                + " PERÍMETRO: "
                + Perimetro().ToString("F2")
                + " DIAGONAL: "
                + Diagonal().ToString("F2");
        }
    }
}
