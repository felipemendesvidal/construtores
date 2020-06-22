using System;

namespace construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância com o método construtor sem argumentos
            Produto sapato = new Produto();

            // Instância da sobrecarga do método construtor com 1 argumento
            Produto chinelo = new Produto(789);
            System.Console.WriteLine(chinelo.Codigo);
        }
    }
}
