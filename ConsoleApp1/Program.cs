using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText(@"C:\Users\carlos.ribeiro\Documents\csvjson.json", Encoding.GetEncoding("ISO-8859-1"));

            List<Jogador> jogadores = JsonConvert.DeserializeObject<List<Jogador>>(json);




            Console.WriteLine("Insira os numeros:");

            string[] numerosLidos = Console.ReadLine().Split(' ');

            List<int> numeros = new List<int>(6);

            foreach (var numero in numerosLidos)
            {
                numeros.Add(Convert.ToInt32(numero));
            }

            Console.WriteLine();
            jogadores.ForEach(jogador =>
            {
                jogador.RegistraJogos();

                jogador.ChecaAcertos(numeros);

                Console.Write(jogador.ImprimeRelatorioJogador());
                Console.WriteLine();
            });

            


            Console.ReadKey();
        }
    }
}
