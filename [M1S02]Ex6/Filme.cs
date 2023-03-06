using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S02_Ex6
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }

        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }

        public void MostrarFilme()
        {
            Console.WriteLine($"Filme: {NomeFilme} Categoria: {Categoria}");
        }
    }
}