using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S02_Ex8
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void MostrarIdade()

        {
            int idade = CalcularIdade();
            Console.WriteLine($"Nome: {Nome}, e tem {idade} anos");
        }

        public int CalcularIdade()

        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;
            if (dataAtual < DataNascimento.AddYears(idade))

            {
                idade--;
            }

            return idade;
        }
    }
}
