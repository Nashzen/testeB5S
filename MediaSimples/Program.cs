using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaSimples
{
    class Program
    {
        /**
         * A função deverá receber um array com pelo menos 3 itens e retornar a média simples de todos os itens do array.
         * Caso o array recebido possua menos que 3 itens, deverá ser retornado o boleano false.
         * Ex: Se a função receber o array [4, 6, 8], deve ser retornado 6.
         * Ex: Se a função receber o array [1, 2], deve ser retornado false.
         *
         * @param array $notas - Array contendo as notas a serem avaliadas.
         * @return int|bool
         */
        static void Main(string[] args)
        {
            MediaSimples();     
        }

        public static void MediaSimples()
        {
            //booleano que para ou continua a construcao da lista
            bool adicionarNumero = true;
            //Lista que armazena os numeros informados
            List<int> listaDeNumeros = new List<int>();


            while (adicionarNumero == true)
            {
                Console.WriteLine("Insira um numero: ");
                listaDeNumeros.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine(string.Join("\t", listaDeNumeros));

                Console.WriteLine("Deseja adicionar mais algum numero? (S/N) ");

                var resposta = Console.ReadLine();               
                if (resposta == "N" || resposta == "n")
                {
                    adicionarNumero = false;
                }
            }

            int tamanhoDaLista = listaDeNumeros.Count;
            int media = listaDeNumeros.Sum() / tamanhoDaLista;

            Console.WriteLine("A media dos numeros é: " + media);
             

        }
    }
}
