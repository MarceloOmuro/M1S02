using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S02_Ex3
{
    public class MensagemCelular
    {
        public int telefone { get; set; }
        public string mensagem { get; set; }
        public MensagemCelular(int Telefone, string Mensagem)

        {
            this.telefone = Telefone;
            this.mensagem = Mensagem;
        }

        public void mensagemImprimir()

        {
            Console.WriteLine();
            ImprimeMensagemDoCelular();
        }
        private void ImprimeMensagemDoCelular()

        {
            Console.WriteLine("Telefone; {0}, mensagem: {1}", telefone, mensagem);
        }
    }
}