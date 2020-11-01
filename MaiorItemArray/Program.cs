using System;

namespace MaiorItemArray
{
    /**
     * Recebe um array de inteiros e deve informar qual é o maior item do mesmo. Caso o array esteja vazio, deverá ser retornado 0.
     * Ex: Se a função receber o array [1,8,2,4,5], a mesma deverá retornar 8.
     *
     * @param array $numeros - Array de inteiros
     */
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int[] arrayDeNumeros = new int[6];

            while (contador <= arrayDeNumeros.Length - 1)
            {
                Console.WriteLine("Insira o " + contador + " valor da lista.");
                arrayDeNumeros[contador] = Int32.Parse(Console.ReadLine());
                contador++;
            }

            Console.WriteLine("O maior valor do array é: " + maiorValorDoArray(arrayDeNumeros));
            Console.ReadLine();


        }

        static int maiorValorDoArray(int[] valores)
        {
            int maiorValor = 0;

            for (int contador = 0; contador <= valores.Length - 1; contador++)
            {
                if (valores[contador] > maiorValor)
                {
                    maiorValor = valores[contador];
                }
            }
            return maiorValor;
        }
    }
}
