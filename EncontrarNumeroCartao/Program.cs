using System;

namespace EncontrarNumeroCartao
{
    /**
     * Descubra o número do cartão de crédito abaixo sabendo que o mesmo é um multiplo de 123457 e o digito de luhn é válido.
     * Número do cartão: 543210******1234
     *
     * O algoritimo de luhn deverá ser utilizado.
     *
     * @return string - O número do cartão de crédito
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroDoCartao = { 5, 4, 3, 2, 1, 0, -1, -1, -1, -1, -1, -1, 1, 2, 3, 4 };

            for (int contadorPrimeiroDigito = 0; contadorPrimeiroDigito <= 9; contadorPrimeiroDigito++)
            {
                numeroDoCartao[6] = contadorPrimeiroDigito;
                for (int contadorSegundoDigito = 0; contadorSegundoDigito <= 9; contadorSegundoDigito++)
                {
                    numeroDoCartao[7] = contadorSegundoDigito;
                    for (int contadorTreceiroDigito = 0; contadorTreceiroDigito <= 9; contadorTreceiroDigito++)
                    {
                        numeroDoCartao[8] = contadorTreceiroDigito;
                        for (int contadorQuartoDigito = 0; contadorQuartoDigito <= 9; contadorQuartoDigito++)
                        {
                            numeroDoCartao[9] = contadorQuartoDigito;
                            for (int contadorQuintoDigito = 0; contadorQuintoDigito <= 9; contadorQuintoDigito++)
                            {
                                numeroDoCartao[10] = contadorQuintoDigito;
                                for (int contadorSextoDigito = 0; contadorSextoDigito <= 9; contadorSextoDigito++)
                                {
                                    numeroDoCartao[11] = contadorSextoDigito;

                                    if (encontrarNumeroCartao(numeroDoCartao) != "!")
                                    {
                                        Console.WriteLine("Encontrei!!!!");
                                        Console.WriteLine(encontrarNumeroCartao(numeroDoCartao));
                                        //Console.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static String encontrarNumeroCartao(int[] cartao)
        {

            int[] cloneCartao = (int[])cartao.Clone();

            for (int contador = cartao.Length - 2; contador > 1; contador -= 2)
            {
                cartao[contador] = cartao[contador] * 2;
            }

            for (int contador_2 = cartao.Length - 2; contador_2 > 1; contador_2 -= 2)
            {
                if (cartao[contador_2] > 9)
                {
                    int soma = 0;

                    soma += (cartao[contador_2] % 10) + (cartao[contador_2] / 10);
                    cartao[contador_2] = soma;
                }
            }

            int somaTotal = 0;
            for (int contador_3 = 0; contador_3 <= cartao.Length - 2; contador_3++)
            {
                somaTotal += cartao[contador_3];
            }

            long multiploFixo = 0;

            for (int i = 0; i < cartao.Length - 1; i++)
            {
                multiploFixo += cartao[i] * Convert.ToInt64(Math.Pow(10, cartao.Length - i - 1));
            }

            if (multiploFixo % 10 == 0 && multiploFixo % 123457 == 0)
            {
                return string.Join("", cloneCartao);
            }
            else
            {
                return "!";
            }
        }
    }
}
