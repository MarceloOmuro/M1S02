using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class FichaDeInscrição
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void MostrarDados()

        {
            Console.WriteLine($"Código:{Id}, Nome:{nome}, Data de Nascimento: {DataNascimento}");
        }
    }
}

