﻿using System;

namespace Estudos_POO
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos()
        {

        }
        public void RemoverProdutos()
        {

        }

        public override string ToString() 
        {
            return " || "
                + Nome 
                + "  ||  Preço: R$" 
                + Preco 
                + "  ||  Quantidade:"
                + Quantidade
                + "  ||  Valor Total em Estoque:"
                + ValorTotalEmEstoque();
        }
    }
}
