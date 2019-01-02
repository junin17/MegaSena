using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Pago { get; set; }
        public string Jogo1 { get; set; }
        public string Jogo2 { get; set; }
        public string Jogo3 { get; set; }
        public string Jogo4 { get; set; }
        public List<Jogo> Jogos { get; set; }


        public void RegistraJogos()
        {
          
            Jogos = new List<Jogo>(4);
            Jogos.Add(converteJogo(Jogo1));
            Jogos.Add(converteJogo(Jogo2));
            Jogos.Add(converteJogo(Jogo3));
            Jogos.Add(converteJogo(Jogo4));
        }

        private Jogo converteJogo(string jogo)
        {
            try
            {
                string[] numeros = jogo.Split('-');

                Jogo retorno = new Jogo();

                foreach(var numero in numeros)
                {
                    retorno.AdicionaNumero(Convert.ToInt32(numero));
                }

                return retorno;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro na Leitura dos jogos");
                Console.ReadKey();
                return null;
            }


        }

        public void ChecaAcertos(List<int> numerosJogo)
        {

            Jogos.ForEach(jogo => jogo.VerificaAcertos(numerosJogo));

        }

        public string ImprimeRelatorioJogador()
        {
            StringBuilder builder = new StringBuilder(500);
            builder.AppendLine(string.Format("Jogador {0}:", Nome));
            
            foreach(var jogo in Jogos)
            {
                builder.AppendLine(jogo.ToString());
            }

            return builder.ToString();
        }
    }
}
