using System;

namespace Excel_Criar
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p1 = new Produto();
           p1.Codigo =  1;
           p1.Nome = "Fender";
           p1.Preco = 5500;

           p1.Cadastrar(p1);
        }
    }
}
