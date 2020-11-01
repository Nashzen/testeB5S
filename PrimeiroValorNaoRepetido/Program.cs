using System;

namespace PrimeiroValorNaoRepetido
{
    /**
     * A função receberá um array contendo apenas inteiros e deverá retornar o primeiro elemento não repetido que existir no array.
     * Caso o array esteja vazio ou todos os elementos forem repetidos, devera ser retornado false
     * Ex: Se a função receber o array [2,2,3,1,1,6], a mesma deve retornar 3.
     * Ex2: Se a função receber o array [2,2], deverá ser retornado false.
     *
     * @param array $array - Array contendo inteiros
     * @return int|bool
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[0];
            String resposta;
            bool validadorArray = true;

            while (validadorArray)
            {
                Console.WriteLine("Insira um valor na lista");
                Array.Resize(ref valores, valores.Length + 1);

                valores[valores.Length - 1] = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Deseja inserir outro valor? (S/N)");
                resposta = Console.ReadLine();

                if (resposta == "n" || resposta == "N")
                {

                    validadorArray = false;

                    Console.WriteLine("Primeiro: " + primeiroNaoRepetido(valores));
                    Console.ReadLine();
                }
            }
        }

        static int primeiroNaoRepetido(int[] valores)
        {
            int resultado = 0;
            int valorEmAnalise = 0;
            int contador_2;
            bool valorRepetido = false;

            for (int contador = 0; contador <= valores.Length - 1; contador++)
            {
                valorEmAnalise = valores[contador];

                for (contador_2 = 0; contador_2 <= valores.Length - 1; contador_2++)
                {

                    if (valorEmAnalise == valores[contador_2] && contador != contador_2)
                    {
                        contador_2 = valores.Length;
                        valorRepetido = true;
                    }

                }

                if (valorRepetido == false)
                {
                    return valorEmAnalise;
                }
                valorRepetido = false;
            }
            return -1;
        }
    }
}
