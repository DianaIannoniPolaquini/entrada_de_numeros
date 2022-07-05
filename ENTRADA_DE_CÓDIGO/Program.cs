using System;

namespace ENTRADA_DE_CÓDIGO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Entre com um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                soma += n;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma de todos os número: {0}.", 
                soma);
        }
    }
}
