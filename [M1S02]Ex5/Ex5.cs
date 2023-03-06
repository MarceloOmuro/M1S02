using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S02_Ex5
{
    public class Cobrar
    {
        private decimal valor;
        private decimal multa;

        public Cobrar(decimal valor, decimal multa)
        {
            this.valor = valor;
            this.multa = multa;
        }

        private decimal CalcularMulta()
        {
            return valor * multa;
        }

        public void Calcular()
        {
            decimal somaValor = valor + CalcularMulta();
            Console.WriteLine($"Valor: {CalcularMulta()} \nMulta: {valor} \nValor Total: {somaValor} \n");
        }
    }
}