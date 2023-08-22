using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do Dólar: ");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            Conversor conversor = new Conversor(cotacao);
            double valorEmReais = conversor.ConverterParaReais(quantidadeDolares);

            Console.WriteLine($"O valor em Reais é: R$ {valorEmReais}");
        }
    }
}
