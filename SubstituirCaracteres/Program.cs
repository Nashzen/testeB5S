using System;

namespace SubstituirCaracteres
{
    class Program
    {
        /**
         * A função deverá receber uma string e substituir todas as vogais da mesma pelo sinal '?'
         * Ex: Se receber a string "A dona aranha" deverá retornar "? d?n? ?r?nh?"
         *
         * @param string - String que será alterada
         * @return string
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase: ");

            string texto = Console.ReadLine();

            Console.WriteLine("Texto sem alterações: " + texto);
            Console.WriteLine("Texto com alterações: " + SubstituirCaracteres(texto));

        }

        public static string SubstituirCaracteres(string texto)
        {
            texto = texto.Replace("a", "?").Replace("e", "?").Replace("i", "?").Replace("o", "?").Replace("u", "?").Replace("A", "?")
                .Replace("E", "?").Replace("I", "?").Replace("O", "?").Replace("U", "?");
            return texto;

        }
    }
}
