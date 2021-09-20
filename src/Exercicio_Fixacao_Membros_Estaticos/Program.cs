using System;
using System.Globalization;

namespace Exercicio_Fixacao_Membros_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoedas c = new ConversorDeMoedas();

            Console.Write("Qual é a cotação do dollar? ");
            c.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dólares você vai comprar? ");
            c.Dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.WriteLine($"Valor a ser pago em Reais = {c.ValorFinal().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
