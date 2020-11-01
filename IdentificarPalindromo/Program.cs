using System;

namespace IdentificarPalindromo
{
    /**
     * A função receberá uma string e deverá retornar true se a mesma for um palindromo. caso contrario, deverá retornar false.
     * Ex: Se for informada a palavra "Arara", a função deverá retornar true.
     *
     * @param string $string - A string a ser analizada
     * @return bool
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto que voce deseja verificar se é um palíndromo: ");
            string texto = Console.ReadLine();

            if (IdentificaPalindromo(texto) == false)
            {
                Console.WriteLine("Não é um palíndromo");
            }
            else
            {
                Console.WriteLine("É um palíndromo");
            }

        }

        public static bool IdentificaPalindromo(string texto)
        {
            string textoSemEspacos = texto.Replace(" ", "");
            string textoMinusculo = textoSemEspacos.ToLower();
            char[] arrayTextoMinusculo = textoMinusculo.ToCharArray();
            Array.Reverse(arrayTextoMinusculo);
            string textoInvertido = new string(arrayTextoMinusculo);

            if (texto == textoInvertido)
            {                
                return true;                

            }
            return false;



        }
    }
}
