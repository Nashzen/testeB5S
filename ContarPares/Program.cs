using System;

namespace ContarPares
{
    class Program
    {
        /**
         * Recebe um array de inteiros maiores que zero e retorna a quantidade de números pares existentes no array
         * Ex: Recebe o array [1,2,3,4,5], a função deverá retornar 2.
         *
         * @param array $array - Array de números inteiros maiores que zero
         * @return int
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de numeros que voce deseja escrever:");
            int tamanhoDaLista = Convert.ToInt32(Console.ReadLine());
            int[] ListaDeNumeros = new int[tamanhoDaLista];

            ContarPares(ListaDeNumeros);
            
        }

        public static void ContarPares(int[] numeros)
        {
            var contador = 0; //Contador para definir a posicao atual e o valor do numero dentro do array
            int quantidadeDePares = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine("Adicione um numero na lista: ");
                numeros[contador] = int.Parse(Console.ReadLine());

                if (numeros[contador] <= 0) {
                    Console.WriteLine("Voce nao pode adicionar nenhum numero menor ou igual a zero, e nao pode adicionar nenhuma letra ou palavra nessa lista.");
                }
                else
                {
                    if (numeros[contador] % 2 == 0)
                    {
                        quantidadeDePares++;
                    }
                    contador++;
                }                                                               
            }

            Console.WriteLine("A quantidade de numeros pares nessa lista eh: " + quantidadeDePares);


        }
    }
}
