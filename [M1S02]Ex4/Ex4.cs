using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S02_Ex4
{
    public class Guitarra
    {
        private static string Afinar { get; set; }
        static Guitarra()

        {
            Afinar = "Sol";
        }
        private static void TomAfinado()

        {
            Console.WriteLine($"A guitarra esta com afinação em {Afinar}");
        }

        public void Tocar()

        {
            TomAfinado();
        }

        public void Tocar(string AfinarNota)

        {
            Afinar = AfinarNota;
            TomAfinado();
        }
    }
}