using System;

namespace InverterString
{
    class Program
    {
        /**
         * A função deverá receber uma string e retornar a mesma invertida.
         * Ex: Se a função receber a string "B5S Tecnologia", deverá retornar "aigolonceT S5B".
         *
         * @param string $string - String que será invertida
         * @return string
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto que voce deseja que seja invertido: ");

            string texto = Console.ReadLine(); 
            
            Console.WriteLine("Texto invertido: ");

            Console.WriteLine(InverterString(texto));

        }

        public static string InverterString(string texto)
        {
            char[] arrayDeTexto = texto.ToCharArray();

            Array.Reverse(arrayDeTexto); //Funcao que inverte o array

            return new string(arrayDeTexto);
        }
    }
}
