using System;
using System.Collections.Generic;
using Aula24;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Produto> carrinho = new List<Produto>();

            Carrinho cart = new Carrinho();
            
            
            Produto p1 = new Produto(1, "luminaria", 299.99f);
            Produto p2 = new Produto(2, "casa", 30.000f);
            Produto p3 = new Produto(3, "celular", 999.87f);
            Produto p4 = new Produto(4, "escova de dente", 9.99f);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p2);

            Produto p5 = new Produto(1, "Celeste", 154f);
            cart.Alterar(1, p4);

        
            cart.MostrarTotal();


        }
    }
}
