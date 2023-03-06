using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class FichaInscrição
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool menorIdade { get; set; }

        public void ImprimeInscrição(int Id, string Nome, DateTime DataNascimento, Boolean MenorIdade)

        {
            this.id = Id;
            this.nome = Nome;
            this.dataNascimento = DataNascimento;
            this.menorIdade = MenorIdade;
        }

        public void ImprimeInscrição()

        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Data de nascimento: {dataNascimento}");

            if (menorIdade == true) { Console.WriteLine("Maior de idade."); }

            else
            {
                Console.WriteLine("Menor de idade.");
            }

        }
    }
}
