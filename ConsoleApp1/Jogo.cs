using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Jogo
    {
        private List<int> numeros;
        public int Acertos { get; set; }


        public Jogo()
        {
            numeros = new List<int>(6);

        }

        public void AdicionaNumero(int numero)
        {
            if (numeros != null && numeros.Count < numeros.Capacity)
            {
                numeros.Add(numero);

                numeros.Sort();
            }
        }

        public void VerificaAcertos(List<int> numerosJogo)
        {

            Acertos = numeros.Intersect(numerosJogo).Count();
        }

        public override string ToString()
        {
            return String.Format("Jogo: {0}  Acertos: {1}", string.Join(" - ", numeros.ToArray()), Acertos);
        }
    }
}