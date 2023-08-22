using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6POO
{
    internal class Conversor
    {
        private double cotacaoDolar;

        public Conversor(double cotacao)
        {
            cotacaoDolar = cotacao;
        }

        public double ConverterParaReais(double valorDolares)
        {
            return valorDolares * cotacaoDolar;
        }
    }
}

